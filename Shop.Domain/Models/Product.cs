using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public ICollection<Stock> Stock { get; set; }
    }
}
