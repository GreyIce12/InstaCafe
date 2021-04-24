using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Shop.Application.Helpers;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.AdminProducts
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;
        //private IHostingEnvironment _env;


        public CreateProduct(ApplicationDbContext context)

        {
            //_env = env;
            _context = context;
        }


        public  async Task<Response> Do(Request request)
        {



            var product = new Product
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Category = request.Category,
               //Image = await request.Photo.SaveImg(_env.WebRootPath, "Images/Products Images/")


        };

            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            return new Response
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Category = product.Category,
                //Image = product.Image

            };
        }
              public class Request
            {
                public string Name { get; set; }
                public string Description { get; set; }

                [Column(TypeName = "decimal(18,4)")]
                public decimal Price { get; set; }


            //    public IFormFile Photo { get; set; }

              //  public string Image { get; set; }

                public string Category { get; set; }
        }

        public class Response
        {

            public int Id { get; set; }
            public string Name { get; set; }

            [NotMapped]
            [Required]
            //public IFormFile Photo { get; set; }

            //public string Image { get; set; }


            public string Category { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }

    
}
