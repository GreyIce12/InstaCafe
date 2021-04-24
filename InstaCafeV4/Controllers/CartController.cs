using Microsoft.AspNetCore.Mvc;
using Shop.Application.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaCafeV4.Controllers
{
    [Route("[controller]/[action]")]
    
    public class CartController : Controller
    {
        [HttpPost("{stockId}/{Quantity}")]
        public async Task<IActionResult> Remove(
        
            int stockId,
        
            int Quantity,
        [FromServices] RemoveFromCart removeFromCart)
        {
            var request = new RemoveFromCart.Request
            {
                StockId = stockId,
                Quantity = Quantity
            };

            var success = await removeFromCart.Do(request);

            if (success)
            {
                return Ok("Item removed from cart");
            }

            return BadRequest("Failed to remove item from cart");
        }
    }
}
