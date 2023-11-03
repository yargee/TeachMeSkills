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

        public ProductModel[] GetProducts()
        {
            return _products.ToArray();
        }
    }
}
