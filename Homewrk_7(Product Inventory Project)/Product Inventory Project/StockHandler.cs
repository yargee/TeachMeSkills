using ProductInventoryProject.Products;

namespace ProductInventoryProject
{
    internal class StockHandler
    {
        public void TakeFromStock(Product product, int quantity)
        {
            var takenProduct = product.Split(quantity);

            var inventory = new Inventory();
            inventory.Init();
            inventory.Add(takenProduct);

        }
    }
}
