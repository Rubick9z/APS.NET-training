using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("VisitedStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }

        [Required]
        [Column(Order=50, TypeName ="varchar")]
        public string IPAddress { get; set; }
    }
}
