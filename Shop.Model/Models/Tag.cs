using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }

        [Column(Order =50, TypeName ="varchar")]
        public string Type { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}
