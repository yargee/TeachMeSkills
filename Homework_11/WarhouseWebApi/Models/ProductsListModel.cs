namespace WarhouseWebApi.Models
{
    public class ProductsListModel
    {
        public ProductModel[] Products { get; private set; }

        public ProductsListModel(ProductModel[] products)
        {
            Products = products;
        }
    }
}
