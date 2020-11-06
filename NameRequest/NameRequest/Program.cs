using System;

namespace NameRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool redo = true;

            do
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();
                bool nameReal = true;
                foreach (char s in name)
                {
                    if (!(Char.IsLetter(s)))
                    {
                        nameReal = false;
                    }

                }

                if (nameReal)
                {
                    if (name.ToLower() == "tim")
                    {
                        Console.WriteLine("Hello Professor!");
                    }
                    else
                    {
                        Console.WriteLine($"Hi {name}.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a name that has purely alphabetical characters.");
                }

                Console.WriteLine("If you would like to exit, please type exit.");
                string exitTruth = Console.ReadLine();

                if (exitTruth.ToLower() == "exit")
                {
                    redo = false;
                }

            } while (redo);
        }
    }
}
