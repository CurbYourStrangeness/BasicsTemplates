using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGuestBook
{
    class Program
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome to the Abstraction!");
        }

        public static Dictionary<string, int> partyGet(Dictionary<string, int> dict)
        {
            Console.WriteLine("Please enter a name!");
            var name = Console.ReadLine();
            var isValidName = true;
            var spaceString = " ";

            dict.Add("", 0);

            foreach (char s in name)
            {
                if (!(Char.IsLetter(s)) && (s.Equals(spaceString)))
                {
                    Console.WriteLine("Please enter a name which is non-numeric and contains no symbols.");
                    isValidName = false;
                }
            }

            if (isValidName)
            {
                Console.WriteLine("Please let us know the size of your party (in integers)!");
                string partySize = Console.ReadLine();

                bool isValidParty = int.TryParse(partySize, out int partyInt); ;

                if (isValidParty)
                {
                    dict.Remove("");
                    dict.Add(name, partyInt);
                }
                else
                {
                    Console.WriteLine("That is not a valid party size!");
                }

                return dict;
            }
            else
            {
                Console.WriteLine("Invalid name.");
                return dict;
            }

        }

        public static void dictPrint(Dictionary<string, int> dict)
        {
            Console.WriteLine("The parties are as follows:");
            dict.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
        }

        static void Main(string[] args)
        {
            bool redo = true;
            var output = new Dictionary<string, int>();
            var ret = new Dictionary<string, int>();

            do
            {
                welcome();

                partyGet(output);


                Console.WriteLine("If you would care to add another party type anything and hit enter--otherwise type exit.");
                string exitTruth = Console.ReadLine();

                if (exitTruth.ToLower() == "exit")
                {
                    redo = false;
                }

            } while (redo);

            dictPrint(output);
        }
    }
}
