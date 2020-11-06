using System;

namespace AgeVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type your age in numeric format: ");
            string stringAge = Console.ReadLine();


            bool isValidAge = int.TryParse(stringAge, out int age);

            if (isValidAge)
            {
                if (age < 20)
                {
                    Console.Write("You were not born in the year 2000");
                }
                else if (age > 20)
                {
                    int thousandAge = age - 20;

                    Console.Write($"You were { thousandAge } in the year 2000");
                }
                else
                {
                    Console.Write("You were born in the year 2000");
                }
            }
        }
    }
}
