using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your firstName?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your lastName?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse (Console.ReadLine());

            int userAge = age % 2;
            if (userAge == 0)
          
            {
                Console.WriteLine("You will retire in 11 years.");
            }

            else if (userAge != 0)

            {
                Console.WriteLine("You will retire in 12 years.");
            }



            Console.WriteLine("What is your birthMonth?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? \nIf you do not know what ROYGBIV is type Help to get a list of ROYGBIV colors.");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "Help")

            {

                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
            }

            Console.WriteLine("How many siblings do you have?");
            string siblings = Console.ReadLine();







        }
    }
}
