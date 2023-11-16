using ProductInventoryProject.Products;

namespace ProductInventoryProject
{
    internal class StockHandler
    {
        public async Task TakeFromStockAsync(Product product, int quantity)
        {
            var takenProduct = product.Split(quantity);

            var inventory = new Inventory();

            Console.WriteLine("inventory take from stock");
            await inventory.AddAsync(takenProduct);
        }
    }
}
