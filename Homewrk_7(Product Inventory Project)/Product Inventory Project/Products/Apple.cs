namespace ProductInventoryProject.Products
{
    internal class Apple : Product
    {
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
