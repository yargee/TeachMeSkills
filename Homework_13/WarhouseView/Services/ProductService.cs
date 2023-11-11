using WarhouseView.Models;

namespace WarhouseView.Services
{
    public class ProductService : IProductService
    {
        private readonly List<ProductModel> _products = new List<ProductModel>();

        public void AddProduct(ProductModel product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Guid guid)
        {
            _products.RemoveAll(x => x.Guid == guid);
        }

        public WarhouseFacadeModel GetProducts()
        {
            if(_products.Count == 0)
            {
                _products.Add(new ProductModel(Guid.NewGuid(), "Test product1", new ProductInfo("Test decription1", 10, 100)));
                _products.Add(new ProductModel(Guid.NewGuid(), "Test product2", new ProductInfo("Test decription2", 10, 100)));
                _products.Add(new ProductModel(Guid.NewGuid(), "Test product3", new ProductInfo("Test decription3", 10, 100)));
            }

            return new WarhouseFacadeModel(_products);
        }

        public WarhouseFacadeModel CalculatePrice(string name)
        {
            return new WarhouseFacadeModel(_products, _products.Where(x => x.Name == name).Sum(x => x.Info.Price * x.Info.Quantity));
        }
    }
}
