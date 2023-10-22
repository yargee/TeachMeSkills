using ProductInventoryProject;
using Microsoft.Extensions.Configuration;
using ProductInventoryProject.Products;

var configuration = new ConfigurationBuilder()
    .AddJsonFile(@"F:\TeachMeSkills\Homewrk_7(Product Inventory Project)\Product Inventory Project\appsettings.json")
    .Build();

IConfiguration outputconfig = configuration.GetSection("AppSettings");

var initializer = new OutputInitializer();
var provider = initializer.GetProvider(outputconfig);


var shop = new Stock();
shop.InitShop();

while (true)
{
    shop.ShowProducts();
    shop.SelectProduct(out Product product, out int quantity);

    var purchase = new StockHandler();
    purchase.TakeFromStock(product, quantity);

    var cart = new Inventory();
    cart.ShowProducts();
}