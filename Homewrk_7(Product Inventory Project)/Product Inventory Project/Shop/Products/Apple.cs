namespace ProductInventoryProject.Shop.Products
{
    internal class Apple : Product
    {
        private int _id;
        public Apple(int id, int price, int quantity, string description) : base(id, price, quantity, description)
        {
        }

        public override Product Split(int quantity)
        {
            DecreaseQuantity(quantity);

            return new Apple(Id, Price, quantity, Description);
        }
    }
}
