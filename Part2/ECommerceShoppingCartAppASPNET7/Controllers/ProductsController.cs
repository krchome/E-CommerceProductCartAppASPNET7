using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ECommerceShoppingCartAppASPNET7.Data;
using ECommerceShoppingCartAppASPNET7.Models;


namespace ECommerceShoppingCartAppASPNET7.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductContext _context;
        private readonly CartService _cartService;

        public ProductsController(ProductContext context, CartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        // GET: Products
        
        public async Task<IActionResult> Index()
        {
            var products = _context.Products.ToList();

            var cart = _cartService.GetCart();
            foreach (var item in cart.Items)
            {
                var product = products.FirstOrDefault(p => p.Id == item.Product.Id);
                if (product != null)
                {
                    product.Quantity = item.Quantity;
                }
            }

            return View(products);
        }
    }

}
