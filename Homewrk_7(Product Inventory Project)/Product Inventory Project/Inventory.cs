using ProductInventoryProject.Products;
using ProductInventoryProject.View;

namespace ProductInventoryProject
{
    internal class Inventory
    {
        public static List<Product> _products { get; private set; } = new List<Product>();

        public void Init()
        {
            var provider = new FileInputProvider();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void ShowProducts()
        {
            Console.WriteLine("Вы забрали со склада:");
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Description} в количестве {product.Quantity} шт. по цене {product.Price}");
            }
            Console.WriteLine();
        }
    }
}
