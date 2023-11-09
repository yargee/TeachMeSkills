namespace WarhouseView.Models
{
    public class ProductInfo
    {
        public string Description { get; }
        public int Quantity { get; }
        public int Price { get;}

        public ProductInfo(string description, int quantity, int price)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
}
