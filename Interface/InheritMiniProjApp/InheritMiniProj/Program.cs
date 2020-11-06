using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritMiniProj
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> RentOptions = new List<IRentable>();
            List<IPurchasable> PurchaseOptions = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 88, ProductName = "Hertz Rentals", QuantityInStock = 100 };
            var book = new BookModel { PageNumber = 888888, ProductName = "Ayn Rand Omnibus and Analysis", QuantityInStock = 666 };
            var excavator = new ExcavatorModel { ProductName = "CAT", QuantityInStock = 88 };

            RentOptions.Add(vehicle);
            RentOptions.Add(book);
            RentOptions.Add(excavator);

            PurchaseOptions.Add(book);
            PurchaseOptions.Add(vehicle);

            Console.Write("Do you want to rent or purchase something: (rent, purchase) ");
            string rentalChoice = Console.ReadLine();

            if (rentalChoice.ToLower() == "rent")
            {
                foreach (var selection in RentOptions)
                {
                    Console.WriteLine($"Item: { selection.ProductName }");
                    Console.Write("Care to rent this item? (yes/no): ");
                    string rentTho = Console.ReadLine();

                    if (rentTho.ToLower() == "yes")
                    {
                        selection.Rent();
                    }


                    Console.Write("Care to return this item? (yes/no): ");
                    string returnTho = Console.ReadLine();

                    if (returnTho.ToLower() == "yes")
                    {
                        selection.ReturnRental();
                    }
                }               
            }
            else if(rentalChoice.ToLower() == "purchase")
            {
                foreach (var obj in PurchaseOptions)
                {
                    Console.Write("Care to purchase this item? (yes/no): ");
                    string buyThis = Console.ReadLine();

                    if (buyThis.ToLower() == "yes")
                    {
                        obj.Purchase();
                    }

                }
            }
            Console.ReadLine();
        }     
    }
}
