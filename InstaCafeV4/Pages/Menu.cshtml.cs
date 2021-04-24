
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;

namespace InstaCafeV4.Pages
{
    public class MenuModel : PageModel
    {
        private ApplicationDbContext _context;
        public MenuModel(ApplicationDbContext context)

        {
            _context = context;
        }

        [BindProperty]
        public IList<GetProducts.ProductViewModel> Menu { get; set; }

        public void OnGet()
        {
            Menu = (IList<GetProducts.ProductViewModel>)new GetProducts(_context).Do();
        }
    }
}
