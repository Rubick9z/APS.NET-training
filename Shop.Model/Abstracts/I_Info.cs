using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Model.Abstracts
{
    public interface  I_Info
    {
        DateTime? CreatedDate { set; get; }
		[MaxLength(50)]
        string CreateBy { get; set; }
        DateTime? UpdateDate { set; get; }
		[MaxLength(50)]
        string UpdateBy { get; set; }
        [Required]
		bool Status {get; set;}
		bool? HomeFlag {get; set;}
		[MaxLength(100)]
		string MetaKeyWord {get; set;}
		[MaxLength(250)]
		string MetaDescription {get; set;}
    }
}
