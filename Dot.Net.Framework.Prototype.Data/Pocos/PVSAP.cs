namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.PVSAP")]
    public partial class PVSAP
    {
        public int ID { get; set; }

        [StringLength(12)]
        public string PVNo { get; set; }

        [StringLength(20)]
        public string PVType { get; set; }

        [StringLength(150)]
        public string CANo { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }

        [StringLength(11)]
        public string PayID { get; set; }

        [StringLength(80)]
        public string Section { get; set; }

        [StringLength(10)]
        public string PVCostCenter { get; set; }

        [StringLength(8)]
        public string PayOrg { get; set; }

        public string PayAddress { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PayDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PrintDate { get; set; }

        public decimal? Amount { get; set; }

        public decimal? VAT { get; set; }

        public decimal? WHT { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? CAAmount { get; set; }

        public decimal? NetAmount { get; set; }

        [StringLength(12)]
        public string ClearCANo { get; set; }

        public string Note { get; set; }

        public decimal? TotalInvoice { get; set; }

        public decimal? TotalVAT { get; set; }

        public decimal? TotalPay { get; set; }

        public decimal? TotalWHT1 { get; set; }

        public decimal? TotalWHT2 { get; set; }

        public decimal? TotalWHT3 { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(20)]
        public string Special { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastInterface { get; set; }

        public string Message { get; set; }

        public int? PVSAPID { get; set; }

        [StringLength(100)]
        public string AttachedFile { get; set; }

        [StringLength(150)]
        public string PayName { get; set; }

        [StringLength(30)]
        public string PrepareByDept { get; set; }

        [StringLength(3)]
        public string Currency { get; set; }

        [StringLength(40)]
        public string ExchangeRate { get; set; }
    }
}
