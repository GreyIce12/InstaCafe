using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Models
{
    public class CartProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public decimal Product { get; set; }

    }
}
