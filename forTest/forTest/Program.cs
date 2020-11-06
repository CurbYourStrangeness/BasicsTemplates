using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace forTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a comma separated list of names");
            string nameList = Console.ReadLine();

            bool isValidString = true;
            foreach (char s in nameList)
            {
                if (!(Char.IsLetter(s)) && (s != ','))
                {
                    Console.WriteLine("Please enter a list of names which are purely alphabetical, separated by commas");
                    isValidString = false;
                }
            }

            if (isValidString)
            {
                string[] nameObjs = nameList.Split(',');

                foreach(string nameo in nameObjs)
                {
                    Console.WriteLine($"Hello, {nameo}!");
                }
            }
        }
    }
}
