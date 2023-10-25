namespace ProductInventoryProject.Products
{
    internal class Cucumber : Product
    {
        public Cucumber(int id, int price, int quantity, string description) : base(id, price, quantity, description)
        {
        }
        public override Product Split(int quantity)
        {
            DecreaseQuantity(quantity);

            return new Cucumber(Id, Price, quantity, Description);
        }
    }
}
