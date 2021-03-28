﻿using Microsoft.EntityFrameworkCore;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.AdminStocks
{
    public class GetStock
    {

        private ApplicationDbContext _context;

        public GetStock(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductViewModel> Do()
        {
            var stock = _context.Products
                .Include(x => x.Stock)
                .Select(x => new ProductViewModel { 
                
                Id = x.Id,
                Description = x.Description,
                Stock = x.Stock.Select(y => new StockViewModel

            {

                Id = y.Id,
                Description = y.Description,
                Quantity = y.Quantity,
            })
            
            }).ToList();

            return stock; 
        }


        public class StockViewModel
        {
            public int Id { get; set; }
            public int ProductId { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
        }
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public IEnumerable<StockViewModel> Stock { get; set; }
        }

    }
}
