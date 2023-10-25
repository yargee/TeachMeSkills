using ProductInventoryProject.Products;
using ProductInventoryProject.View;
using System.Text;

namespace ProductInventoryProject
{
    internal class Inventory
    {
        public static List<Product> _products { get; private set; } = new List<Product>(); //вместо статики можно считывать из файла куда выводим отчет
        public static IReadOnlyCollection<Product> Products => _products;

        public void Add(Product product)
        {
           var item = _products.FirstOrDefault(x => x.Id == product.Id);

            if(item != null)
            {
                item.IncreaseQuantity(product.Quantity);
            }
            else
            {
                _products.Add(product);
            }
        }

        public string GetInventoryAsString()
        {
            var result = new StringBuilder();
            var price = 0;

            foreach (var item in _products)
            {
                result.Append($"{item.Description} - {item.Quantity} шт.\n");
                price += item.Price*item.Quantity;
            }

            result.Append($"Общая стоимость товаров {price}");

            return result.ToString();
        }
    }
}
