
using Microsoft.EntityFrameworkCore;

using Shop.Application.Infrastructure;
using Shop.Database;

using System.Collections.Generic;
using System.Linq;


namespace Shop.Application.Cart
{
    public class GetCart
    {
        private ISessionManager _sessionManager;

        private ApplicationDbContext _ctx;
        
        public GetCart(ISessionManager sessionManager, ApplicationDbContext ctx)
        {
            _sessionManager = sessionManager;
            _ctx = ctx;
        }

        public class Response
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public int StockId { get; set; }
           
            
        }

        public ICollection <Response> Do()
        {
            var cartList = _sessionManager.GetCart();

            
            if (cartList == null)
                return new List<Response>();

            var response = _ctx.Stocks
                .Include(x => x.Product).AsEnumerable()
                .Where(x => cartList.Any(y => y.StockId == x.Id))
                .Select(x => new Response
                {
                    Name = x.Product.Name,
                    Price = x.Product.Price,
                    StockId = x.Id,
                    //Image = x.Image,
                    Quantity = cartList.FirstOrDefault(y => y.StockId == x.Id).Quantity,
                    
                })
                .ToList();

            
            return response;
        }


    }
}
