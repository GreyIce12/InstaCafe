using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaCafe1.Models
{
    public class Product
    {
        public int Prouct_ID { get; set; }
        public string Prouct_Name { get; set; }
        public Category Category_ID { get; set; }
        public string isActive{ get; set; }
        public string isDelete { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified_Date { get; set; }
        public string description { get; set; }
        public string Product_Image { get; set; }
        public string isFeatured { get; set; }
        public int Quantity { get; set; }


    }
}
