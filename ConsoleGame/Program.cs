﻿using System;
using System.Security.Cryptography;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ButtNekid's Bounce House");
            Console.Write("What's your name:");

            string name = Console.ReadLine();
            Random random = new Random();
            byte hp = (byte)random.Next(8, 20);
            byte ac = (byte)random.Next(8, 20);
            byte ap = (byte)random.Next(8, 20);

            Player player = new Player(name, hp, ac, ap);
            System.Console.WriteLine($"Starting Armor class:{player.ArmorClass}");
            System.Console.WriteLine($"Starting Attack Points:{player.AttackPoints}");
            System.Console.WriteLine($"Starting Hitpoints:{player.HitPoints}");

            Console.WriteLine($"You awake in a cold stone, dark room. You feel dazed and are having trouble remembering anything about your past.");

            if (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("You don't even know your own name.");
            }
            else
            {
                Console.WriteLine($"You know your name is {name}.");
            }

            Console.WriteLine($@"You grope around in the darkness until you find a door handle. You feel some resistance as
you turn the handle, but the rusty lock breaks with little effort. You see your captor
standing with his back to you outside the door.
You throw open the door and grab a rusty metal sword while charging toward your captor
He turns...");
        }
    }
}
