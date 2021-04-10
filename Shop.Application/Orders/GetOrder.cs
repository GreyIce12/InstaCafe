using Microsoft.EntityFrameworkCore;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Application.Orders
{

    public class GetOrder
    {
        private ApplicationDbContext _ctx;

        public GetOrder(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public class Response
        {
            public string OrderRef { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }

            public IEnumerable<Product> Products { get; set; }

            public string TotalValue { get; set; }
        }

        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
            public int Quantity { get; set; }
            public string StockDescription { get; set; }
        }

        public Response Do(string reference)
        {
            return _ctx.Orders
                .Where(x => x.OrderRef == reference)
                .Include(x => x.OrderStocks)
                .ThenInclude(x => x.Stock)
                .ThenInclude(x => x.Product)
                .Select(x => new Response
                {

                    OrderRef = x.OrderRef,

                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    Address1 = x.Address1,
                    Address2 = x.Address2,
                    City = x.City,
                    PostCode = x.PostCode,


                    Products = x.OrderStocks.Select(y => new Product
                    {
                        Name = y.Stock.Product.Name,
                        Description = y.Stock.Product.Description,
                        Price = $"$ {y.Stock.Product.Price.ToString("N2")}",
                        Quantity = y.Quantity,
                        StockDescription = y.Stock.Description,
                    }),

                    TotalValue = x.OrderStocks.Sum(y => y.Stock.Product.Price).ToString("N2")

                }).FirstOrDefault();
        }
            

        /*private static Func<Order, Response> Projection = (order) =>
            new Response
            {
                OrderRef = order.OrderRef,

                FirstName = order.FirstName,
                LastName = order.LastName,
                Email = order.Email,
                PhoneNumber = order.PhoneNumber,
                Address1 = order.Address1,
                Address2 = order.Address2,
                City = order.City,
                PostCode = order.PostCode,

                Products = order.OrderStocks.Select(y => new Product
                {
                    Name = y.Stock.Product.Name,
                    Description = y.Stock.Product.Description,
                    Value = $"£ {y.Stock.Product.Price.ToString("N2")}",

                    Qty = y.Quantity,
                    StockDescription = y.Stock.Description,
                }),

                TotalValue = order.OrderStocks.Sum(y => y.Stock.Product.Price).ToString("N2")
            };*/
    }
}