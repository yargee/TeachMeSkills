namespace ProductInventoryProject.Shop.Products
{
    internal class Potato : Product
    {
        public Potato(int id, int price, int quantity, string description) : base(id, price, quantity, description)
        {
        }

        public override Product Split(int quantity)
        {
            DecreaseQuantity(quantity);

            return new Potato(Id, Price, quantity, Description);
        }
    }
}
