using System;

namespace MethodOverridingDemo
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Authenticate and start");
        }

        internal abstract void SetClock();


    }
}
