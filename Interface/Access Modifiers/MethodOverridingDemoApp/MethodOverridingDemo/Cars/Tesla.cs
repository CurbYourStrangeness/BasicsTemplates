using System;

namespace MethodOverridingDemo
{
    public class Tesla : Car
    {

        public override void StartCar()
        {
            Console.WriteLine("Biometric authorization required. Pass/Fail");
        }

        internal override void SetClock()
        {
            Console.WriteLine("Sets self automatically. Spooky.");
        }
    }
}
