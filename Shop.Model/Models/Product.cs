using Shop.Model.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Shop.Model.Models
{
    [Table("Products")]
    public class Product : Info
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name {get; set;}

        [Required]
        [Column(Order =100, TypeName ="varchar")]
        public string Alias { get; set; }

        public int CategoryID { get; set; }

        [MaxLength(250)]
	    public string Image { get; set; }

        public XElement MoreImage { get; set; }

        [Required]
        public decimal Price { get; set; }
        public decimal? Promotion { get; set; }
        public int? Warranty { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public string Content { get; set; }
		public bool?  HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }

        public IEnumerable<ProductTag> ProductTags { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
