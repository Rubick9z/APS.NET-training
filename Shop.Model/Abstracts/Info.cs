using System;


namespace Shop.Model.Abstracts
{
    public abstract class Info : I_Info
    {
        public DateTime? CreatedDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool Status { get; set; }
        public bool? HomeFlag { get; set; }
        public string MetaKeyWord { get; set; }
        public string MetaDescription { get; set; }
    }
}
