﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace InstaCafe1.Models
{
    [Table("Users_Role")]
    public partial class UsersRole
    {
        [Key]
        [Column("User_Role_Id")]
        public int UserRoleId { get; set; }
        [Column("User_Id")]
        public int? UserId { get; set; }
        [Column("Role_Id")]
        public int? RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("UsersRoles")]
        public virtual Role Role { get; set; } = default!;
    }
}