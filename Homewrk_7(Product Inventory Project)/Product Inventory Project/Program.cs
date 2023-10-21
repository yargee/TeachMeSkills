using ProductInventoryProject.Customer;
using ProductInventoryProject.Shop;
using ProductInventoryProject.Shop.Products;

var shop = new Shop();

shop.InitShop();

while (true)
{
    shop.ShowProducts();
    shop.SelectProduct(out Product product, out int quantity);

    var provider = new PurchaseProvider();
    provider.MakePurchase(product, quantity);

    var cart = new Cart();
    cart.ShowProducts();
}