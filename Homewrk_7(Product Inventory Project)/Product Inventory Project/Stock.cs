using ProductInventoryProject.Products;

namespace ProductInventoryProject
{
    internal class Stock
    {
        private List<Product> _products = new List<Product>();

        public void InitStock()
        {
            _products.Add(new Apple(0, 10, 500, "Яблоко зеленое"));
            _products.Add(new Cucumber(1, 15, 500, "Огурец сладкопопый"));
            _products.Add(new Tomato(2, 18, 500, "Помидоры черри"));
            _products.Add(new Potato(3, 10, 500, "Картофель сезонный"));
        }

        public void SelectProduct(out Product product, out int quantity)
        {
            Console.WriteLine("Введите код продукта.");
            product = GetProduct(); 
            Console.WriteLine("Введите количество.");
            quantity = GetQuantity();
            Console.WriteLine();
        }

        public void ShowProducts()
        {
            foreach (var product in _products)
            {
                Console.Write($"{product.Description} цена: {product.Price}. В наличии {product.Quantity}. Чтобы забрать введите {product.Id}");
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private Product GetProduct()
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out int id))
            {
                var product = _products.FirstOrDefault(p => p.Id == id);
                return product;
            }

            return null;
        }

        private int GetQuantity()
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out int quantity))
            {
                return quantity;
            }

            return default;
        }
    }
}
