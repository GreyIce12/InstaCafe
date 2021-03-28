﻿using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Shop.Application.AdminProducts
{
    public class GetProducts

    {
        private ApplicationDbContext _context; 
        public GetProducts(ApplicationDbContext context)

        {
            _context = context;

        }

        public IEnumerable<ProductViewModel> Do() => _context.Products.ToList().Select(x => new ProductViewModel
        {
            Id = x.Id,
            Name = x.Name,
            Price = x.Price,

        });
            public class ProductViewModel
            {

                public int Id { get; set; }
                public string Name { get; set; }

                public decimal Price { get; set; }
            }
    
    }


    
}
