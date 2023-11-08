namespace WarhouseView.Models
{
    public class ProductsListModel
    {
        public List<ProductModel> Products { get; }

        public ProductsListModel(List<ProductModel> products)
        {
            Products = products;
        }
    }
}
