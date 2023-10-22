namespace ProductInventoryProject.Products
{
    internal abstract class Product
    {
        public int Id { get; }
        public int Price { get; }
        public int Quantity { get; private set; }
        public string? Description { get; }

        public Product(int id, int price, int quantity, string description)
        {
            Id = id;
            Price = price;
            Quantity = quantity;
            Description = description;
        }

        public void DecreaseQuantity(int value)
        {
            if (value <= Quantity)
            {
                Quantity -= value;
            }
        }

        public abstract Product Split(int quantity);
    }
}
