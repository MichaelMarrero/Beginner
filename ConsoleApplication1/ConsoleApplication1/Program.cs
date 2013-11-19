using System;
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

            Console.ReadLine();
                
        }
    }
}
