using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Encounters
    {
        static Random rand = new Random();

        //Encounter Generic


        //Encounters
        public static void firstEncounter()
            {
            Console.WriteLine("You throw open the door and grab a rusty metal sword while charging toward your captor");
            Console.WriteLine("He turns...");
            Console.ReadKey();
            Combat(false, "Human Rogue", 1, 4);
            }


        //Encounter Tools
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

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
                    Console.WriteLine("You move dexterously towards the enemy swinging your weapon. The"+n+"Jumps quickly to the side, while striking you in the process.");
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
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
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
                         
                    }
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
