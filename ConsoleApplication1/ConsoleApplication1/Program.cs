﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();


            
            var randomizer = new Random();
            var choice = randomizer.Next(1, 10);
            if (choice == 1)
            {
                Console.WriteLine("Hello " + name);
            }
            else
            {
                Console.WriteLine("Hello " + name + " How are you?");
            }

            bool keepGoing = true;

            do
            {
                Console.WriteLine(" What would you like to do today?");
                var action = Console.ReadLine();

                if (action == "goodbye") 
                {
                    keepGoing = false;
                }

                if (action == "Nothing")
                {
                    Console.WriteLine(" You must be bored!");
                   
                }

                if (action == "Going Outside")
                {
                    Console.WriteLine("Good Choice!");
                }

            }
            while (keepGoing);
            
                
        }
    }
}
