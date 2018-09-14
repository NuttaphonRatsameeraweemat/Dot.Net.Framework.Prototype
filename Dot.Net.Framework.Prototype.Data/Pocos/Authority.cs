namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.Authority")]
    public partial class Authority
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string EmpNo { get; set; }

        [Required]
        [StringLength(10)]
        public string ComCode { get; set; }

        public decimal? Remark1 { get; set; }

        public decimal? Remark2 { get; set; }

        public decimal? Remark3 { get; set; }

        public decimal? Remark4 { get; set; }

        public decimal? Remark5 { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastInterface { get; set; }
    }
}
