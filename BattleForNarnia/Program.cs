using System;

namespace BattleForNarnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, new recruit! Welcome to Narnia! My Name is Reepicheep!");

            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

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
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("So, Here we have our Blacksmith, Bandor.");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine($"Bandor, this is {name}. Say Hello {name}!");


            Console.ReadLine();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Bandor: Lets get you fitted with armour!");

            Console.WriteLine("What is your size?");

            Console.WriteLine("we have small, medium, large, and xl");


            string armour = Console.ReadLine();

            if (armour == "small")
            {
                Console.WriteLine("Splendid! This Armour will help you stay mobile and stealthy!");
                Console.WriteLine("Perfect for small lads like yourself.");
            }
            else if (armour == "medium")
            {
                Console.WriteLine("Then this is going to be a great fit, built for speed and with more durability!");
                Console.WriteLine("Perfect for well built men like yourself.");
            }
            else if (armour == "large")
            {

                Console.WriteLine("Ah, A Tank!! With this armour you'll definitely be able to hold the front line!");
                Console.WriteLine("Perfect for Men of our stature!");

            }
            else if (armour == "xl")
            {
                Console.WriteLine("Great scott!! Your as big as our boulders! This Armour will allow you to be shot from our Catapults, safely of course!");
                Console.WriteLine("This is going to be fun!");
            }

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Now that your fitted, Would you like to go see about getting a blade?");

            response = Console.ReadLine();

            if (response == "yes")
            {
                Console.WriteLine("Great Let's Go!");
            }
            else if (response == "no")
            {
                Console.WriteLine("Too bad! Let's go!");
            }

            Console.WriteLine($"{name}, this is is Rabidash, finest Bladesmith in all the land!");

            Console.WriteLine($"{name}, Say hello!");

            response = Console.ReadLine();

            if (response == "hello")
            {
                Console.WriteLine($"Rabidash: Hello {name}!");
            }
            else
            {
                Console.WriteLine("That was rude.... anyways moving on");
            }



            Console.WriteLine("Here we have an assortment of different blades, fit for any situation.");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine($"Which weapon better fits you fighting style {name}, Axes or Swords?");


            response = Console.ReadLine();

            if (response == "swords")
            {
                Console.WriteLine($"Great! With your Armour style being {armour}, I believe this sword will fit you best!");
            }

            else if (response == "axes")
            {
                Console.WriteLine($"Great! With your Amour style being {armour}, I believe this axe will best suit you!");
            }
        }
    }
}
