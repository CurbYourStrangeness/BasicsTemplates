using System;

namespace InheritMiniProj
{
    partial class Program
    {
        public class ExcavatorModel : InventoryModel, IRentable
        {
            public int SqFeetEarthExcavated { get; set; }

            public void Dig()
            {
                Console.WriteLine("Presently Digging. OP is running concurrently.");
            }

            public void Rent()
            {
                QuantityInStock -= 1;
                Console.WriteLine("A unit has been rented out.");
            }

            public void ReturnRental()
            {
                QuantityInStock += 1;
                Console.WriteLine("A unit is returned.");
            }
        }


     
    }
}
