using ECommerceShoppingCartAppASPNET7.Models;

namespace ECommerceShoppingCartAppASPNET7
{
    public interface ICartService
    {
        void AddItem(Product product, int quantity);
        void RemoveItem(string productId);
        void ClearCart();
        Cart GetCart();
    }
}
