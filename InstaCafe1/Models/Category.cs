using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaCafe1.Models
{
    public class Category
    {
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public string isActive { get; set; }
        public string IsDelete { get; set; }
    }
}
