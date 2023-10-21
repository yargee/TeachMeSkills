using ProductInventoryProject.Shop.Products;

namespace ProductInventoryProject.Shop
{
    internal class Shop
    {
        private List<Product> _products = new List<Product>();

        public void InitShop()
        {
            _products.Add(new Apple(0, 10, 500, "Яблоко зеленое"));
            _products.Add(new Apple(1, 12, 500, "Яблоко красное"));
            _products.Add(new Apple(2, 14, 500, "Яблоко желтое"));
            _products.Add(new Cucumber(3, 15, 500, "Огурец сладкопопый"));
            _products.Add(new Cucumber(4, 12, 500, "Огурец горькопопый"));
            _products.Add(new Cucumber(5, 8, 500, "Корнишончик"));
            _products.Add(new Tomato(6, 18, 500, "Помидоры черри"));
            _products.Add(new Tomato(7, 16, 500, "Помидоры желтые"));
            _products.Add(new Tomato(8, 17, 500, "Помидоры сливовидные"));
            _products.Add(new Potato(9, 10, 500, "Картофель сезонный"));
            _products.Add(new Potato(10, 20, 500, "Картофель мытый"));
            _products.Add(new Potato(11, 15, 500, "Картофель для варки"));
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
                Console.Write($"{product.Description} цена: {product.Price}. В наличии ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(product.Quantity);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Для покупки введите ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(product.Id);
                Console.ForegroundColor = ConsoleColor.White;
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
