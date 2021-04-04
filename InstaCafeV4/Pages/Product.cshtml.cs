using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Product;
using Shop.Database;

namespace InstaCafeV4.Pages
{
    public class ProductModel : PageModel
    {
        private ApplicationDbContext _context;
        public ProductModel(ApplicationDbContext context)
        
        {
            _context = context;
        }

        public GetProduct.ProductViewModel Products { get; set; }

        public void OnGet( string name)
        {

            Products = new GetProduct(_context).Do(name);
        }
    }
}
