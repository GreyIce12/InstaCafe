using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;


namespace InstaCafeV4.Pages.Checkout
{
    public class CustomerInformationModel : PageModel
    {
        [System.Obsolete]
        private IHostingEnvironment _env;

        [System.Obsolete]
        public CustomerInformationModel(IHostingEnvironment env)
        {
            _env = env;
        }

        [BindProperty]
        public AddCustomerInformation.Request CustomerInformation { get; set; }

        [System.Obsolete]
        public IActionResult OnGet()
        {
            var information = new GetCustomerInformation(HttpContext.Session).Do();

            if(information == null)
            {
                if (_env.IsDevelopment())
                {
                    CustomerInformation = new AddCustomerInformation.Request
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "JohnDoe@gmail.com",
                        PhoneNumber = "1876235627",
                        Address1 = "ATL",
                        Address2 = "Wisconsin",

                        City = "ATL",
                        PostCode = "8JDH#",
                    };
                }
                return Page();
            }

            else
            {
                return RedirectToPage("/Checkout/Payment");
            }
        }

        public IActionResult OnPost()

        {

            if (!ModelState.IsValid)
            {
                return Page();

            }

            new AddCustomerInformation(HttpContext.Session).Do(CustomerInformation);

            return RedirectToPage("/Checkout/Payment");
        }
    }
}
