namespace InheritMiniProj
{
    partial class Program
    {
        public interface IRentable : IInventoryItem
        {
            void Rent();
            void ReturnRental();
        }


     
    }
}
