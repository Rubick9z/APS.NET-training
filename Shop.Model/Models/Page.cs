using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }

        public string Content { get; set; }
        [MaxLength(100)]
        public string MetaKeyWord { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        public bool? Status { get; set; }
    }
}
