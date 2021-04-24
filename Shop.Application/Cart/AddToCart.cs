using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Application.Infrastructure;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Application.Cart
{
    public class AddToCart
    {
        private ISessionManager _sessionManager;
        private ApplicationDbContext _ctx;
        public AddToCart(ISessionManager sessionManager, ApplicationDbContext ctx)
        {
            _sessionManager = sessionManager;
            _ctx = ctx;
        }

        public class Request
        {
            public int StockId { get; set; }
            public int Quantity { get; set; }
        }

        public async Task<bool> Do(Request request)
        {


            var stockOnHold = _ctx.StockOnHolds.AsEnumerable().Where(x => x.SessionId == _sessionManager.GetId()).ToList();
            var stockToHold = _ctx.Stocks.Where(x => x.Id == request.StockId).FirstOrDefault();

            if(stockToHold.Quantity < request.Quantity)
            {
                return false;
            }

            _ctx.StockOnHolds.Add(new StockOnHold
            {

                StockId = stockToHold.Id,
                SessionId = _sessionManager.GetId(),
                Quantity = request.Quantity,
                ExpiryDate = DateTime.Now.AddMinutes(20)
            });

            stockToHold.Quantity -= -request.Quantity;

            foreach (var stock in stockOnHold)
            {
                stock.ExpiryDate = DateTime.Now.AddMinutes(20);
            }

            await _ctx.SaveChangesAsync();

            _sessionManager.AddProduct(request.StockId, request.Quantity);
            
            
            return true;

        }

}
}
