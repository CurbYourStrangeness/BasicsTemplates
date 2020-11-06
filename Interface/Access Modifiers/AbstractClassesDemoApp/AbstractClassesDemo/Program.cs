using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.ProdName = "Where do emotinos come from";

            MobilityEnhance car = new Car();

            Console.ReadLine();
        }
    }

    public interface MobilityEnhance
    {
       void IncreaseOutputReturnforWork();
    }

    public abstract class Vehicle : MobilityEnhance
    {
        public string VIN { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int ManufactureYear { get; set; }

        public string Brand { get; set; }

        public void IncreaseOutputReturnforWork()
        {
            Console.WriteLine("Model and implement CombustionEngine using this method as an abstract base.");
        }
    }

    public class Car : Vehicle
    {
        public int WheelNum { get; set; } = 4;
    }
}
