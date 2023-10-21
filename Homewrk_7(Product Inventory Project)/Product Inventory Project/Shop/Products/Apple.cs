namespace ProductInventoryProject.Shop.Products
{
    internal class Apple : Product
    {
        private int _id;
        public Apple(int id, int price, int quantity, string description) : base(id, price, quantity, description)
        {
        }
    }
}
