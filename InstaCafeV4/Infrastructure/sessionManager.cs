using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Application.Infrastructure;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.InstaCafeV4.Infrastructure
{
    public class sessionManager : ISessionManager
    {
        private readonly ISession _session;
        public sessionManager(IHttpContextAccessor httpContextAccessor)
        {
            
            _session = httpContextAccessor.HttpContext.Session;
        }

        public void AddCustomerInformation(CustomerInformation customer)
        {
            var stringObject = JsonConvert.SerializeObject(customer);

            _session.SetString("customer-info", stringObject);
        }

        public void AddProduct(int stockId, int Quantity)
        {

            var cartList = new List<CartProduct>();
            var stringObject = _session.GetString("cart");

            
            if (!string.IsNullOrEmpty(stringObject))
            {
                cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);
            }

            if(cartList.Any(x => x.StockId == stockId))
            {
                cartList.Find(x => x.StockId == stockId).Quantity += Quantity;
            }
            else
            {
                cartList.Add(new CartProduct
                {
                    StockId = stockId,
                    Quantity = Quantity
                });

            }
            
            stringObject = JsonConvert.SerializeObject(cartList);
             
            
            //TODO : append Items
            
            _session.SetString("cart", stringObject);
            
            
        }

        public List<CartProduct> GetCart()
        {

            var stringObject = _session.GetString("cart");

            if (string.IsNullOrEmpty(stringObject))
                return null;

            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);

            return cartList;
        }

        public CustomerInformation GetCustomerInformation()
        {
            var stringObject = _session.GetString("customer-info");

            if (string.IsNullOrEmpty(stringObject))
                return null;

            var customerInformation = JsonConvert.DeserializeObject<CustomerInformation>(stringObject);
            return customerInformation;
        }

        public string GetId()
        {
            return _session.Id;
        }

        public void RemoveProduct(int stockId, int Quantity)
        {
            var cartList = new List<CartProduct>();
            var stringObject = _session.GetString("cart");

            if (string.IsNullOrEmpty(stringObject)) return;

            cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);

            if (!cartList.Any(x => x.StockId == stockId)) return;

            var product = cartList.First(x => x.StockId == stockId);
            product.Quantity -= Quantity;

            if (product.Quantity <= 0)
            {
                cartList.Remove(product);
            }

            stringObject = JsonConvert.SerializeObject(cartList);

            _session.SetString("cart", stringObject);
        }
    }
}
