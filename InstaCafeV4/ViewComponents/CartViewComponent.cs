using Microsoft.AspNetCore.Mvc;
using Shop.Application.Cart;


namespace InstaCafeV4.ViewComponents
{

    public class CartViewComponent:ViewComponent
    {
        private GetCart _getCart;

        public CartViewComponent( GetCart getCart)
        {
            _getCart = getCart;
        }
        
        public IViewComponentResult Invoke([FromServices] GetCart _getcart, string view = "Default" )
        {
            return View(view, _getcart.Do());
        }
    }
}
