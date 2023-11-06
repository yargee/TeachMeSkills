namespace WarhouseWebApi.Models
{
    public class ProductInfo
    {
        public string Description { get; private set; } = string.Empty;
        public int Quantity { get; private set; }
        public int Price { get; private set; }

        public ProductInfo(string description, int quantity, int price)
        {
            Description = description; 
            Quantity = quantity;
            Price = price;
        }
    }
}
