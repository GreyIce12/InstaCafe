using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.AdminProducts;
using System.Collections.Generic;
using Shop.Database;



namespace InstaCafeV4.Pages
{
    public class IndexModel : PageModel
    {

        private ApplicationDbContext _ctx;
        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]       
        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }
        
        public void OnGet()
        {
           Products = new GetProducts(_ctx).Do();
        }

        
    }
}
