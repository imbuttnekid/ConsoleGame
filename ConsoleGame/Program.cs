using System;
using System.Threading;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ButtNekid's Bounce House");
            Thread.Sleep(1000);
            Console.Write("What's your name:");

            string name = Console.ReadLine();
            Random random = new Random();
            byte hp = (byte)random.Next(8, 20);
            byte ac = (byte)random.Next(8, 20);
            byte ap = (byte)random.Next(8, 20);

            Player player = new Player(name, hp, ac, ap);
            Console.WriteLine($"Starting Armor class:{player.ArmorClass}");
            Thread.Sleep(100);
            Console.WriteLine($"Starting Attack Points:{player.AttackPoints}");
            Thread.Sleep(100);
            Console.WriteLine($"Starting Hitpoints:{player.HitPoints}");
            Thread.Sleep(100);
            Console.WriteLine($"You awake in a cold stone, dark room. You feel dazed and are having trouble remembering anything about your past.");
            Thread.Sleep(100);

            if (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("You don't even know your own name.");
            }
            else
            {
                Console.WriteLine($"You know your name is {name}.");
            }

            Thread.Sleep(1000);
            Console.WriteLine($@"You grope around in the darkness until you find a door handle. You feel some resistance as
you turn the handle, but the rusty lock breaks with little effort. You see your captor
standing with his back to you outside the door.
You throw open the door and grab a rusty metal sword while charging toward your captor
He turns...");

            Thread.Sleep(100);
            Enemy rogue = new Enemy("Human Rogue", 1, 1, 1);

            Console.WriteLine($"You encounter a {rogue.Name}");
            Thread.Sleep(100);
            Console.WriteLine("| (A)ttack (D)efend |\n| (R)un    (H)eal   |");
        }
    }
}
