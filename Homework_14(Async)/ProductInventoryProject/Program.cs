using ProductInventoryProject;
using ProductInventoryProject.Products;


var outputHandler = new OutputHandler();
outputHandler.Initialize();

var stock = new Stock();
stock.InitShop();

while (true)
{
    stock.ShowProducts();
    stock.SelectProduct(out Product product, out int quantity);

    var purchase = new StockHandler();
    await purchase.TakeFromStockAsync(product, quantity);

    Console.WriteLine("AAA");

    var inventory = new Inventory();
    var result = inventory.GetInventoryAsString();
    outputHandler.PrintResult(result);
}