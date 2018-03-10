using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Products")]
    class Product
    {
        [Key]
        public int ID { get; set; }

        public string Name {get; set;}
        public string Alias { get; set; }
        public int CategoryID { get; set; }
	    public string Image { get; set; }
        public string MoreImage { get; set; }
        public double Price { get; set; }
        public double Promotion { get; set; }
        public int Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string MetaKeyWord { get; set; }
        public string MetaDescription { get; set; }
	    public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
	    public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
	    public bool Status { get; set; }
        public bool  HomeFlag { get; set; }
        public bool  HotFlag { get; set; }
        public int ViewCount { get; set; }
     }
}
