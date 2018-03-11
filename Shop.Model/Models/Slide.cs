using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Description {get; set;}

        [Required]
        [MaxLength(250)]
        public string Image { get; set; }

        [Required]
        [MaxLength(250)]
        public string URL { get; set; }

        public int DisplayOrder { get; set; }
	    public bool Status { get; set; }
    }
}
