using System;

namespace ConsoleGame
{
    public class Encounters
    {
        static Random rand = new Random();

        //Encounter Generic


        //Encounters
        public static void firstEncounter()
        {
            Console.WriteLine("You throw open the door and grab a rusty metal sword while charging toward your captor");
            Console.WriteLine("He turns...");
            Console.ReadKey();
            Combat(false, "Human Rogue", 1, 1);
        }
        public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine("You turn the corner and there you see a hulking beast...");
            Console.ReadKey();
            Combat(true,"",0,0);

        
        }
        public static void WizardEncounter()
        {
            Console.Clear();
            Console.WriteLine("A door opens up before you and you walk into a poorly lit room. You see a tall slender man with a long beard standing before you.");
            Console.ReadKey();
            Combat(false, "Wizard", 4, 2);


        }


        //Encounter Tools
        public static void RandomEncounter()
        {
            switch(rand.Next(0,1))
            {
                case 0:
                    BasicFightEncounter();
                    break;
                case 1:
                    WizardEncounter();
                    break;
           }
        }

        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
                n = GetName();
                p = Program.currentPlayer.GetPower();
                h = Program.currentPlayer.GetHealth();
            }
            else 
            {
                n = name;
                p = power;
                h = health;
            }
            while(h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + " | " + h);
                Console.WriteLine();
                Console.WriteLine("====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (R)un    (H)eal   |");
                Console.WriteLine("====================");
                Console.WriteLine("  Potions:  " + Program.currentPlayer.potion + "  Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if(input.ToLower() == "a"||input.ToLower() == "attack")
                {
                    //ATTACK
                    Console.WriteLine("You move dexterously towards the enemy swinging your weapon. The "+n+" jumps quickly to the side, while striking you in the process.");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    Console.WriteLine("As the " + n + " prepare to strike you plant your feet and ready you sword in a defensive stance.");
                    int damage = (p/4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue)/2;
                    Console.WriteLine("You lose " + damage + " health and deal" + attack + "damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //RUN
                    if(rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you sprint away from the " + n + ", its strike catches you on the back sending you sprawling on the ground");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                        Console.ReadKey();
                        //go to store
                    }
                    else
                    {
                        Console.WriteLine("You use your crazy ninja skills to juke the " + n + " and successfully escape!");
                        Console.ReadKey();
                        Shop.LoadShop(Program.currentPlayer);
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                    //HEAL
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("Out of potions");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("The " + n + " strikes you and you lose " + damage + " health");
                    }
                    else
                    {
                        Console.WriteLine("You drink a potion successfully!");
                        int potionV = 5;
                        Console.WriteLine("You gain "+potionV+" health");
                        Program.currentPlayer.health += potionV;
                        Console.WriteLine("As you were occupied the " + n + "advanced, stiking you");
                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health");
                    }
                    Console.ReadKey();
                    if(Program.currentPlayer.health <= 0)
                    {
                        //Death Code
                        Console.WriteLine("You fall and the last thing you see is the " + n + " stands menacingly over you. ");
                        Console.WriteLine("GAME OVER");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                    Console.ReadKey();
            }
            int c = Program.currentPlayer.GetCoins();
            Console.WriteLine("As you stand victorious over the " + n + ", it's body dissolves into "+c+" gold coins");
            Program.currentPlayer.coins += c;
            Console.ReadKey();
        }

        public static string GetName()
        {
            switch(rand.Next(0, 4))
            {
                case 0:
                    return "Skeleton";
                case 1:
                    return "Zombie";
                case 2:
                    return "Drow";
                case 3:
                    return "Grave Robber";
            }
            return "Human Fighter";
        }
    }
}
