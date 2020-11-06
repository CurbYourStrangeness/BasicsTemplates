using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idDict
{
    class Program
    {
        static void Main(string[] args)
        {
            bool redo = true;
            Dictionary<int, string> empIds = new Dictionary<int, string>();

            empIds.Add(32964, "Fred Roberts");
            empIds.Add(21489, "Jenny Scrimes");
            empIds.Add(79428, "Ishmael Devorah");
            empIds.Add(98527, "Magane Chikujoin");
            empIds.Add(99999, "Yukari Yakumo");

            do
            {

                Console.WriteLine("Please supply an ID to find an employee record. You may choose between 00000 and 99999.");
                string keyMap = Console.ReadLine();

                bool isValidKey = int.TryParse(keyMap, out int id);

                if (isValidKey)
                {
                    if (empIds.ContainsKey(id))
                    {
                        Console.WriteLine($"The associated record is for {empIds[id]}.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a key the dictionary contains.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid key.");
                }

                Console.WriteLine("If you would care to go again type anything and hit enter--otherwise type exit.");
                string exitTruth = Console.ReadLine();

                if (exitTruth.ToLower() == "exit")
                {
                    redo = false;
                }
            } while (redo);
        }
    }
}
