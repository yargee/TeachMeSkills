using WarhouseWebApi.Models;

namespace WarhouseWebApi.Services
{
    public interface IProductService
    {
        ProductModel[] GetProducts();
        void AddProduct(ProductModel product);
        void RemoveProduct(ProductModel product);
    }
}
