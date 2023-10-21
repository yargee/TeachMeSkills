namespace ProductInventoryProject.Shop.Products
{
    internal class Tomato : Product
    {
        public Tomato(int id, int price, int quantity, string description) : base(id, price, quantity, description)
        {
        }

        public override Product Split(int quantity)
        {
            DecreaseQuantity(quantity);

            return new Tomato(Id, Price, quantity, Description);
        }
    }
}
