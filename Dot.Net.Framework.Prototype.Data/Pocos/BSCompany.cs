namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.BSCompany")]
    public partial class BSCompany
    {
        public int ID { get; set; }

        [StringLength(16)]
        public string BSNo { get; set; }

        public int? Seq { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }

        public string Topic { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ValueDate { get; set; }

        public int? TotalNoCR { get; set; }

        public string BankAccount { get; set; }

        public decimal? DebitAmount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ExportDate { get; set; }
    }
}
