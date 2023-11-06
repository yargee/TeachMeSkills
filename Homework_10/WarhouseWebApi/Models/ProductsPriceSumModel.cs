namespace WarhouseWebApi.Models
{
    public class ProductsPriceSumModel
    {
        public int PriceSum { get; set; }

        public ProductsPriceSumModel(int priceSum)
        {
            PriceSum = priceSum;
        }
    }
}
