using System;
using System.Collections.Generic;

namespace nameForeach0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool redo0 = true;
            List<string> names = new List<string>();

            do
            {
                Console.WriteLine("Please enter a firstname you are comfortable with.");
                var name = Console.ReadLine();
                bool isValidString = true;

                foreach (char s in name)
                {
                    if (!(Char.IsLetter(s)))
                    {
                        Console.WriteLine("Please enter a name which is purely alphabetical.");
                        isValidString = false;
                    }   
                }

                if (isValidString)
                {
                    names.Add(name);
                    Console.WriteLine("Name added");
                }

                Console.WriteLine("Would you like to add another name? If so, type anything and hit enter--otherwise type exit.");
                string exitTruth = Console.ReadLine();

                if (exitTruth.ToLower() == "exit")
                {
                    redo0 = false;
                }
            } while (redo0);


            //fix (i think) oreach skipping values
            foreach (string nameo in names)
            {
                Console.WriteLine($"Hello, {nameo}!");
            }
        }
    }
}
