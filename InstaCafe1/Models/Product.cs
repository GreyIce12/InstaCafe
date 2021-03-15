﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace InstaCafe1.Models
{
    [Table("Product")]
    [Index(nameof(ProuctName), Name = "UQ__Product__0D828C1A2ECE8D9B", IsUnique = true)]
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
        }

        [Key]
        [Column("Product_Id")]
        public int ProductId { get; set; }
        [Column("Prouct_Name")]
        [StringLength(255)]
        public string? ProuctName { get; set; }
        [Column("Category_ID")]
        public int CategoryId { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        [Column("isDelete")]
        public bool? IsDelete { get; set; }
        [Column("Created_Date", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("Modified_Date", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("description", TypeName = "datetime")]
        public DateTime? Description { get; set; }
        [Column("Product_Image")]
        public string? ProductImage { get; set; }
        [Column("isFeatured")]
        public bool? IsFeatured { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Price { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category? Category { get; set; }
        [InverseProperty(nameof(Cart.Product))]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}