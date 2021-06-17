using System;
using System.Threading;

namespace ConsoleGame
{
    public static class Encounter
    {
        public static void RunCombatLoopWith(this Player player, Enemy enemy)
        {
            Console.WriteLine($"You encounter:{enemy.Name}");
            Thread.Sleep(100);
            Console.WriteLine("| (A)ttack (D)efend |\n| (R)un    (H)eal   |");
            Thread.Sleep(100);
            string input = Console.ReadLine().ToUpper();
            input = ValidateInput(input);

            while (player.isAlive && enemy.isAlive)
            {
                switch (input)
                {
                    case "A": AttackEnemy(player, enemy); break;
                    case "D": break;
                    case "H": break;
                    case "R": break;
                }
            }
        }

        private static void AttackEnemy(Player player, Enemy enemy)
        {
            Console.WriteLine($"You move dexterously towards the enemy swinging your weapon. The {enemy.Name} jumps quickly to the side, while striking you in the process.");
            Thread.Sleep(100);
            
            Console.WriteLine();
        }

        private static string ValidateInput(string input)
        {
            while (String.IsNullOrWhiteSpace(input) || input != "A" && input != "D" && input != "R" && input != "H")
            {
                Console.Write("Sorry, didn't understand.\n| (A)ttack (D)efend |\n| (R)un    (H)eal   |");
                input = Console.ReadLine().ToUpper();
            }

            return input;
        }
    }
}