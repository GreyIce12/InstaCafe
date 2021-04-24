using Shop.Database;

using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Application.AdminProducts
{
    public class UpdateProduct
    {
        private ApplicationDbContext _context;
        public UpdateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Do(Request request)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == request.Id);

            product.Name = request.Name;
                product.Description = request.Description;
                product.Price = request.Price;
             //   product.Image = request.Image;
            product.Category = request.Category;
         
            await _context.SaveChangesAsync();

            return new Response { 
            
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
             //   Image = product.Image,
                Category = product.Category
            };
        }
        public class Request
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            [Column(TypeName = "decimal(18,4)")]
            public decimal Price { get; set; }
           // public string Image { get; set; }
            public string Category { get; set; }
        }

        public class Response
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }

         //   public string Image { get; set; }
            public string Category { get; set; }
        }
    }
}
