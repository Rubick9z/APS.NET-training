using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [Column(Order = 100, TypeName ="varchar")]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}
