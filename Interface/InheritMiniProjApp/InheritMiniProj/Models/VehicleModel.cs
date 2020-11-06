using System;

namespace InheritMiniProj
{
    partial class Program
    {
        public class VehicleModel : InventoryModel, IRentable, IPurchasable
        {
            public int DealerFee { get; set; }

            public void Purchase()
            {
                QuantityInStock -= 1;
                Console.WriteLine("Unit has been purchased.");
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
