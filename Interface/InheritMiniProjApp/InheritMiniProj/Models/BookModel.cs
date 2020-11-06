using System;

namespace InheritMiniProj
{
    partial class Program
    {
        public class BookModel : InventoryModel, IRentable, IPurchasable
        {
            public int PageNumber { get; set; }

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
