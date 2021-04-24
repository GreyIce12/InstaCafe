using System;
using Shop.Database;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Shop.Application.Products
{
    public class GetProducts
    {

        private ApplicationDbContext _context;
        public GetProducts(ApplicationDbContext context)

        {
            _context = context;
        }

        public IEnumerable<ProductViewModel> Do() =>

            _context.Products
            .Include(x => x.Stock)
            .Select(x => new ProductViewModel
            {

                Name = x.Name,
                Description = x.Description,
                 Price = $"$ {x.Price.ToString("N2")}",
                 Category = x.Category,
              //   Image = x.Photo,

                 StockCount = x.Stock.Sum(y => y.Quantity)
            })
            .ToList();

        

        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            [Column(TypeName = "decimal(18,4)")]
            public string Price { get; set; }
            public string Category { get; set; }

            //public  IFormFile Image { get; set; }
            public int StockCount { get; set; }
            
        }
    }
}
