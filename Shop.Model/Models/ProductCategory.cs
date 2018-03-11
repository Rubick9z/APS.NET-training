﻿using Shop.Model.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Shop.Model.Models
{
    [Table("ProductCategory")]
    
    public class ProductCategory : Info
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID;

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Column(Order =100, TypeName ="varchar")]
        public string Alias { get; set; }

        public int? ParentID { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

	    public int? DisplayOder { get; set; } 

        [MaxLength(250)]
        public string Image { get; set; }
	   
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
