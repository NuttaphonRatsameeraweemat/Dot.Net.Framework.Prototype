namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.HRCompany")]
    public partial class HRCompany
    {
        [Key]
        [StringLength(10)]
        public string ComCode { get; set; }

        [StringLength(10)]
        public string SAPComCode { get; set; }

        [StringLength(10)]
        public string ShortText { get; set; }

        [StringLength(40)]
        public string LongText { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastInterface { get; set; }

        [StringLength(40)]
        public string Email { get; set; }
    }
}
