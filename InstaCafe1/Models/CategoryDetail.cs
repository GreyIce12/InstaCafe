using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstaCafe1.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required (ErrorMessage ="Category Name Required")]
        [StringLength(100, ErrorMessage = "min 3 and max 100 characters allowed",MinimumLength = 5 )]
        public string CategoryName { get; set; }
        
        public bool IsActive { get; set; }
        
        public bool IsDelete { get; set; }

    }

    public class ProductDetail
    {
        public int ProductId { get; set; }
        
        
        [Required (ErrorMessage ="Product Name Required")]
        [StringLength(100, ErrorMessage = "min 3 and max 100 characters allowed", MinimumLength = 5)]
        public string ProuctName { get; set; }
        
        [Required]
        [Range(1,50)]
        public int CategoryId { get; set; }
        
        public bool? IsActive { get; set; }
        
        public bool? IsDelete { get; set; }
        
        public DateTime? CreatedDate { get; set; }
        
        public DateTime? ModifiedDate { get; set; }
        [Required(ErrorMessage ="Descrition Required")]
        public DateTime? Description { get; set; }
        
        public string ProductImage { get; set; }
        
        public bool? IsFeatured { get; set; }

        [Required]
        [Range(typeof(int), "1","500", ErrorMessage ="Invalid Quantity")]
        public int? Quantity { get; set; }
    }
}
