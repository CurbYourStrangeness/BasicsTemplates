using System;

namespace ClassConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string nameString = Console.ReadLine();

            Console.Write("Please enter your age: ");
            string ageInt = Console.ReadLine();

            bool isValidAge = int.TryParse(ageInt, out int age);

            if (nameString is string)
            {

                //Add logic to validate against people listing food objects, or items like furniture, etc. as their name.
                var lowerName = nameString.ToLower();
                if (lowerName == "bob" || lowerName == "sue")
                {
                    if (isValidAge)
                    {
                        if (age < 21)
                        {
                            Console.WriteLine($"You may want to wait { 21 - age } years to take the course.");
                        }
                        else if (age >= 21)
                        {
                            Console.WriteLine("Hello Professor");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid age.");
                    }
                }
                else
                {
                    if (isValidAge)
                    {
                        if (age < 21)
                        {
                            Console.WriteLine($"You may want to wait { 21 - age } years to take the course.");
                        }
                        else if (age >= 21)
                        {
                            Console.WriteLine($"{lowerName} has been added to the roster.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid age.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid name.");
            }
        }
    }
}
