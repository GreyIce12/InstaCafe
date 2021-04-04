using System;
using Shop.Database;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Application.Product
{
    public class GetProducts
    {

        private ApplicationDbContext _context;
        public GetProducts(ApplicationDbContext context)

        {
            _context = context;
        }

        public IEnumerable<ProductViewModel> Do() =>

            _context.Products.ToList().Select(x => new ProductViewModel
            {

                Name = x.Name,
                Description = x.Description,
                 Price = $"$ {x.Price.ToString("N2")}",
            });

        

        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            [Column(TypeName = "decimal(18,4)")]
            public string Price { get; set; }
        }
    }
}
