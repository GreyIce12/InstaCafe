﻿using Microsoft.AspNetCore.Http;
using Shop.Database;
using Shop.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Application.AdminProducts
{
    public class GetProduct
    {
        private ApplicationDbContext _context;
        public GetProduct(ApplicationDbContext context)

        {
            _context = context;
        }

        public ProductViewModel Do(int id) =>
        
            _context.Products.Where(x => x.Id == id).Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                Category = x.Category,
                //Image = 

            })

        .FirstOrDefault();    
        
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            [Column(TypeName = "decimal(18,4)")]
            public decimal Price { get; set; }
            ///public IFormFile Image { get; set; }
            public string Category { get; set; }
        }
    }
}