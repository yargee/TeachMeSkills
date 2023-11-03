namespace WarhouseWebApi.Models
{
    public class ProductInfo
    {
        public string Description { get; private set; } = string.Empty;
        public int Quantity { get; private set; }

        public ProductInfo(string description, int quantity)
        {
            Description = description; 
            Quantity = quantity;
        }
    }
}
