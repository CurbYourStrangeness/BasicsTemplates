using System;

namespace advancedBreakpoint0
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i == 73)
                {
                    throw new TypeAccessException();
                }
            }
        }
    }
}
