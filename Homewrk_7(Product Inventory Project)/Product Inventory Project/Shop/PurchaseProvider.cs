using ProductInventoryProject.Customer;
using ProductInventoryProject.Shop.Products;

namespace ProductInventoryProject.Shop
{
    internal class PurchaseProvider
    {
        public void MakePurchase(Product product, int quantity)
        {
            var customerWallet = new Wallet();

            if(customerWallet.TrySpend(product.Price * quantity))
            {
                var cashbox = new Cashbox();
                cashbox.Add(product.Price *quantity);

                var purchasedProduct = product.Split(quantity);

                var cart = new Cart();
                cart.Add(purchasedProduct);
            }
        }
    }
}
