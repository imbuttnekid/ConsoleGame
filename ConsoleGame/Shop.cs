using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Shop
    {
        public static void LoadShop(Player p)
        {
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int potionP;
            int armorP;
            int weapP;
            int difP;

            while (true)
            {
                potionP = 20 + 10 * p.mods;
                armorP = 100 * (p.armorValue + 1);
                weapP = 100 * p.weaponValue;
                difP = 300 + 100 * p.mods;


                Console.Clear();
                Console.WriteLine("        SHOP          ");
                Console.WriteLine("======================");
                Console.WriteLine("| (W)eapon : $" + weapP);
                Console.WriteLine("| (A)rmor : $" + armorP);
                Console.WriteLine("| (P)otions : $" + potionP);
                Console.WriteLine("| (D)ifficulty : $" + difP);
                Console.WriteLine("======================");
                Console.WriteLine("| (E)xit\n\n");

                Console.WriteLine(p.name + "'s STATS");
                Console.WriteLine("======================");
                Console.WriteLine("| Gold : " + p.coins);
                Console.WriteLine("| Current Health : " + p.health);
                Console.WriteLine("| Weapon Strength : " + p.weaponValue);
                Console.WriteLine("| Armor Strength : " + p.armorValue);
                Console.WriteLine("| Amount of Potions : " + p.potion);
                Console.WriteLine("| Current Difficulty : " + p.mods);
                Console.WriteLine("======================");
                //Wait for input
                string input = Console.ReadLine().ToLower();
                if(input == "w" || input == "weapon")
                    TryBuy("weapon", weapP, p);
                else if (input == "a" || input == "armor")
                    TryBuy("armor", armorP, p);
                else if (input == "p" || input == "potion")
                    TryBuy("potion", potionP, p);
                else if (input == "d" || input == "difficulty")
                    TryBuy("dif", difP, p);
                else if (input == "e" || input == "exit")
                    break;
                

            }
        }
        public static void TryBuy(string item, int cost, Player p)
        {
            if(p.coins >= cost)
            {
                if (item == "weapon")
                    p.weaponValue++;
                else if (item == "armor")
                    p.armorValue++;
                else if (item == "potion")
                    p.potion++;
                else if (item == "dif")
                    p.mods++;

                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("Broke ass");
                Console.ReadKey();
            }
        }
    }
}
 