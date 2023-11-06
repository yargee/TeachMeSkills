using WarhouseWebApi.Models;

namespace WarhouseWebApi.Services
{
    public class ProductService : IProductService
    {
        private readonly List<ProductModel> _products = new List<ProductModel>();

        public void AddProduct(ProductModel product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(ProductModel product)
        {
            _products.Remove(product);
        }

        public ProductsListModel GetProducts()
        {
            return new ProductsListModel(_products.ToArray());
        }

        public ProductsPriceSumModel CalculatePrice(string name)
        {
            return new ProductsPriceSumModel(_products.Where(x => x.Name == name).Sum(x => x.Info.Price * x.Info.Quantity));
        }
    }
}
