using System;
using System.Threading;

namespace ConsoleGame
{
    public static class Encounter
    {
        public static void Combat(this Player player, Enemy enemy)
        {
            Console.WriteLine($"You encounter:{enemy.Name}");
            Thread.Sleep(100);
            Console.WriteLine("| (A)ttack (D)efend |\n| (R)un    (H)eal   |");
            Thread.Sleep(100);
            string input = Console.ReadLine().ToUpper();
            input = ValidateInput(input);
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