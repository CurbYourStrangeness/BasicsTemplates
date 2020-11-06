using System;

namespace ExceptionThrow0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                exTest();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void exTest()
        {
            throw new InvalidOperationException();
        }
    }
}
