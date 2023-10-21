using ProductInventoryProject.Shop.Products;

namespace ProductInventoryProject.Customer
{
    internal class Cart
    {
        private static List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void ShowProducts()
        {
            Console.WriteLine("Вы приобрели:");
            foreach (var product in _products)
            {
                Console.WriteLine(product.Description);
            }
        }
    }
}
