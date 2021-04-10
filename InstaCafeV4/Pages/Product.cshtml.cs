using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;
using Shop.Application.Products;
using Shop.Database;
using System.Threading.Tasks;

namespace InstaCafeV4.Pages
{
    public class ProductModel : PageModel
    {
        private ApplicationDbContext _context;
        public ProductModel(ApplicationDbContext context)
        
        {
            _context = context;
        }

        [BindProperty]
        public AddToCart.Request CartViewModel { get; set; }
        

        public GetProduct.ProductViewModel Product { get; set; }

        public async Task<IActionResult> OnGet( string name)
        {

            Product = await new GetProduct(_context).Do(name.Replace("-", " "));

            if(Product == null)
            {
                return RedirectToPage("Index");

            }
            else
            {
                return Page();
            }
        }

        public async Task<IActionResult> OnPost()
        {
            var stockAdded = await new AddToCart(HttpContext.Session, _context).Do(CartViewModel);

            if (stockAdded)
            return RedirectToPage("Cart");

            else
            {
                return Page();
            }
        }
    }
}
