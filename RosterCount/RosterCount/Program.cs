using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterCount
{
    class Program
    {
        static void Main(string[] args)
        {

            bool redo = true;
            List<string> Nameos = new List<string>();
            do
            {
               
                Console.WriteLine("Please supply a name to add to the list.");
                string nameo = Console.ReadLine();

                bool isValidNameo = true;
                foreach (char s in nameo)
                {
                    if (!(Char.IsLetter(s)))
                    {
                        isValidNameo = false;
                    }
                }

                if (isValidNameo)
                {
                    Nameos.Add(nameo);
                }
                else
                {
                    Console.WriteLine("Please enter a name with all alphabetical characters.");
                }

                Console.WriteLine("Would you like to go again? If so, type anything and hit enter--otherwise type exit.");
                string exitTruth = Console.ReadLine();

                if (exitTruth.ToLower() == "exit")
                {
                    redo = false;
                }
            } while (redo);

            Console.WriteLine(Nameos.Count());
        }
    }
}
