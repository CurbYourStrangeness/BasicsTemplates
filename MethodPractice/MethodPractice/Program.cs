using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome to my program!");
        }

        public static string nameGet()
        {
            Console.WriteLine("Please enter a name!");
            var name = Console.ReadLine();
            var isValidName = true;

            var nope = " ";
            foreach (char s in name)
            {
                if (!(Char.IsLetter(s)) && (s.Equals(nope)))
                {
                    Console.WriteLine("Please enter a name which is non-numeric and contains no symbols.");
                    isValidName = false;
                }
            }

            if (isValidName)
            {
                return name;
            }
            else {
                Console.WriteLine("Invalid name.");
                return nope;
            }
            
        }

        public static void helloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            bool redo = true;
           
            do
            {
                welcome();
                               
                helloName(nameGet());
                               

                Console.WriteLine("Would you like to add another name? If so, type anything and hit enter--otherwise type exit.");
                string exitTruth = Console.ReadLine();

                if (exitTruth.ToLower() == "exit")
                {
                    redo = false;
                }
            } while (redo);
                        
        }
               
    }
}
