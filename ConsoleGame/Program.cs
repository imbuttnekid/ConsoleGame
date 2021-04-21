using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.firstEncounter();
        }

        public static void Start()
        {
            Console.WriteLine("ButtNekid's Bounce House");
            Console.WriteLine("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a cold stone, dark room. You feel dazed and are having trouble remembering anything about your past.");
            if (currentPlayer.name == "")
                Console.WriteLine("You don't even know your own name.");
            else
                Console.WriteLine("You know your name is " + currentPlayer.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You grope around in the darkness until you find a door handle. You feel some resistance as");
            Console.WriteLine("you turn the handle, but the rusty lock breaks with little effort. You see your captor");
            Console.WriteLine("standing with his back to you outside the door.");
        }



    }
}
