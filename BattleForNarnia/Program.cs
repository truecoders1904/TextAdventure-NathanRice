using System;

namespace BattleForNarnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, new recruit! Welcome to Narnia! My Name is Reepicheep!");

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine()

            Console.WriteLine($"Great to meet you {name}, I understand this is your first time on the Battlefield?");

            string response = Console.ReadLine();

                if (response == "yes")
                {
                    Console.WriteLine($"Not to worry {name}! Let's get you fitted with Armour and a Blade!");
                }
                else if (response == "no")
                {
                    Console.WriteLine("Ah! A seasoned warrior! Let me show you around!");
                }
            
            Console.WriteLine("So, Here we have our Blacksmith, Bandor.");

            Console.WriteLine($"Bandor, this is {name}.);

            Console.WriteLine("Bandor: Lets get you fitted with armour first!");

            Console.WriteLine("What is your size?");

            Console.WriteLine("we have small, medium, large, and xl");


            response = Console.ReadLine();

                if (response == "small")

                {
                    Console.WriteLine("Splendid! This Armour will help you stay mobile and stealthy!");
                    Console.WriteLine("Perfect for small lads like yourself.");
                }

                else if (response == "medium")

                {
                    Console.WriteLine("Then this is going to be a great fit, built for speed and with more durability!");
                }

                else if (response == "large")
                {

                    Console.WriteLine("Ah, A Tank!! With this armour you'll definitely be able to hold the front line!");
                }

                else if (response == "xl")
                {
                    Console.WriteLine("Great scott!! Your as big as our boulders! This Armour will allow you to be shot from our Catapults, safely of course!");
                }
            
            Console.WriteLine("Now that your fitted, lets get you a blade!");

            Console.WriteLine($"{name}, this is is Rabidash, finest Bladesmith in all the land!");

            Console.WriteLine($"Rabidash: Hello {name}!");

            Console.WriteLine(");


        }
    }
}
