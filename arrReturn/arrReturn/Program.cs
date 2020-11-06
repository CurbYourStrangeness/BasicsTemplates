using System;

namespace arrReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            names[0] = "Administrator D";
            names[1] = "Yukari Yakumo";
            names[2] = "Magane Chikujoin";

            bool redo = true;
            //in a do/while loop ask the user to specify which name they want returned
            do
            {
                Console.WriteLine("Please select a number from 1 - 3 to be provided with a name: ");
                var selection = Console.ReadLine();
                bool isValidSelection = int.TryParse(selection, out int select);

                if (isValidSelection)
                {
                    if (((select - 1) > 2) || ((select - 1) < 0))
                    {
                        Console.WriteLine("Please enter a number within the prescribed range.");
                    }
                    else
                    {
                        Console.WriteLine(names[select - 1]);
                    }
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
