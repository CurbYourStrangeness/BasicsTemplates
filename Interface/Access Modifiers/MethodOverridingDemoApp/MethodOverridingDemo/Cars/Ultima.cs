using System;

namespace MethodOverridingDemo
{
    public class Ultima : Car
    {
        internal override void SetClock()
        {
            Console.WriteLine("It's 2am somewhere. Why not have that as your permanent time?");
        }
    }
}
