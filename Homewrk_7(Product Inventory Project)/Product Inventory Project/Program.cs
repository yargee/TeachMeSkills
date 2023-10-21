using ProductInventoryProject.Shop;

var shop = new Shop();
shop.InitShop();
shop.ShowProducts();
var product = shop.GetProductById();
var provider = new PurchaseProvider();
provider.MakePurchase(product, 10);