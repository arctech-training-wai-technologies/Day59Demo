﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Day59DemoValidations.Models
{
    public partial class Department
    {
        public Department()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string Description { get; set; }

        [InverseProperty("DepartmentRef")]
        public virtual ICollection<User> Users { get; set; }
    }
}