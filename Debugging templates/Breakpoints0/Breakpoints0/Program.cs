using System;

namespace Breakpoints0
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num = 10;

            for (int i = 0; i < 999999999; i++)
            {
                ulong totes = num * 5;

                num += totes;
            }

            Console.WriteLine(num);
        }
    }
}
