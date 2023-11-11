namespace WarhouseView.Models
{
    public class WarhouseFacadeModel
    {
        public List<ProductModel> Products { get; }
        public int TempotarySum { get; }

        public WarhouseFacadeModel(List<ProductModel> products)
        {
            Products = products;
        }

        public WarhouseFacadeModel(List<ProductModel> products,  int tempotarySum)
        {
            Products = products;
            TempotarySum = tempotarySum;
        }
    }
}
