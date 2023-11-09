using WarhouseView.Models;

namespace WarhouseView.Services
{
    public interface IProductService
    {
        WarhouseFacadeModel GetProducts();
        void AddProduct(ProductModel product);
        void RemoveProduct(Guid guid);
        WarhouseFacadeModel CalculatePrice(string name);
    }
}
