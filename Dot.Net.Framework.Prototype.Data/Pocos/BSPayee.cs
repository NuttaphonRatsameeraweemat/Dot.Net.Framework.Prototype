namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.BSPayee")]
    public partial class BSPayee
    {
        public int ID { get; set; }

        public int? BSCompanyID { get; set; }

        public int? Seq { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }

        public int? TopicID { get; set; }

        [StringLength(40)]
        public string BankAccount { get; set; }

        [StringLength(20)]
        public string FiDoc { get; set; }

        [StringLength(40)]
        public string PayeeTaxID { get; set; }

        [StringLength(100)]
        public string PayeeName { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(20)]
        public string Status { get; set; }
    }
}
