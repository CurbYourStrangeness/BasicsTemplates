namespace InheritMiniProj
{
    partial class Program
    {
        public class InventoryModel : IInventoryItem
        {
            public string ProductName { get; set; }
            public int QuantityInStock { get; set; }
        }


     
    }
}
