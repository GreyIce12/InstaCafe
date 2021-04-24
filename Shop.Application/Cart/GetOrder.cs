﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Shop.Application.Infrastructure;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.Cart
{
    public class GetOrder
    {
        private ISessionManager _sessionManager;

        private ApplicationDbContext _ctx;

        public GetOrder(ISessionManager sessionManager, ApplicationDbContext ctx)
        {
            _sessionManager = sessionManager;
            _ctx = ctx;
        }

        public  class Response
        {
            public IEnumerable<Product> Products { get; set; }
            public CustomerInformation CustomerInformation { get; set; }

            public int GetTotalCharges() => Products.Sum(x => x.Price * x.Quantity);
        }
        public class Product 
        {
           
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public int StockId { get; set; }
            public int Price { get; set; }

        }

        public class CustomerInformation
        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }


            public string PhoneNumber { get; set; }

            public string Address1 { get; set; }

            public string Address2 { get; set; }

            public string City { get; set; }

            public string PostCode { get; set; }
        }

        public Response Do()
        {
            var cart = _sessionManager.GetCart();
            
            var ListOfProducts = _ctx.Stocks
                .Include(x => x.Product).AsEnumerable()
                .Where(x => cart.Any(y => y.StockId == x.Id))
                .Select(x => new Product
                {
                    ProductId = x.ProductId,
                    StockId = x.Id,
                    Price = (int)x.Product.Price*100,
                    Quantity = cart.FirstOrDefault(y => y.StockId == x.Id).Quantity,
                })
                .ToList();

            var customerInformation = _sessionManager.GetCustomerInformation();

            return new Response
            {
                Products = ListOfProducts,
                CustomerInformation = new CustomerInformation
                {
                    FirstName = customerInformation.FirstName,

                    LastName = customerInformation.LastName,

                    Email = customerInformation.Email,

                    PhoneNumber = customerInformation.PhoneNumber,

                    Address1 = customerInformation.Address1,

                    Address2 = customerInformation.Address2,

                    City = customerInformation.City,

                    PostCode = customerInformation.PostCode,

                }

            };
        }

    }
}
  
