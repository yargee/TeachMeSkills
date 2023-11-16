using ProductInventoryProject.Products;
using ProductInventoryProject.View;
using System.Text;

namespace ProductInventoryProject
{
    internal class Inventory
    {
        private readonly object _lock = new object();
        public static List<Product> _products { get; } = new List<Product>();
        public static IReadOnlyCollection<Product> Products => _products;

        public async Task AddAsync(Product product)
        {
            var item = _products.FirstOrDefault(x => x.Id == product.Id);

            Console.WriteLine("inventory add" + item);

            var task = new Task(() => 
            {
                if (item != null)
                {
                    Console.WriteLine("Продукт есть в инвентаре, увеличиваем количество");
                    lock (_lock)
                    {

                        item.IncreaseQuantity(product.Quantity);
                    }
                }
                else
                {
                    Console.WriteLine("Продукта нет в инвентаре, добавляем");
                    lock (_lock)
                    {
                        _products.Add(product);
                    }
                }
            });

            task.Start();
            await task;
        }

        public string GetInventoryAsString()
        {
            var result = new StringBuilder();
            var price = 0;

            foreach (var item in _products)
            {
                result.Append($"{item.Description} - {item.Quantity} шт.\n");
                price += item.Price * item.Quantity;
            }

            result.Append($"Общая стоимость товаров {price}\n");

            return result.ToString();
        }
    }
}
