using ProductInventoryProject.Shop;
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ваши покупки:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Description} в количестве {product.Quantity} шт. по цене {product.Price}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ваш баланс: {Wallet.Balance} рублей.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
