using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonModel person0 = new PersonModel
            {
                fName = "Finn",
                lName = "The Human",
                Email = "landofOo@gmail.com"
            };

            Console.WriteLine(person0.ToString());

            Console.ReadLine();
        }
    }
}
