using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerEmail { get; set; }

        [Required]
        [Column(Order =15, TypeName ="varchar")]
        public string CustomerMobile { get; set; }

        [MaxLength(250)]
        public string CustomerMessage { get; set; }

	    DateTime? CreateDate { get; set; }

        [MaxLength(50)]
        public string CreateBy{ get; set; }

        [MaxLength(150)]
        public string PaymentMethod { get; set; }

        [Required]
        [MaxLength(50)]
        public string PaymentStatus{ get; set; }

        public int Status  { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
