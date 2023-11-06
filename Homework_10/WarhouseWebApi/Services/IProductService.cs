using WarhouseWebApi.Models;

namespace WarhouseWebApi.Services
{
    public interface IProductService
    {
        ProductsListModel GetProducts();
        void AddProduct(ProductModel product);
        void RemoveProduct(ProductModel product);
        ProductsPriceSumModel CalculatePrice(string name);
    }
}
