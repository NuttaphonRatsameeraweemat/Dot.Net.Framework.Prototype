namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.PVItemSAP")]
    public partial class PVItemSAP
    {
        public int ID { get; set; }

        [StringLength(12)]
        public string PVNo { get; set; }

        public int? Seq { get; set; }

        [StringLength(16)]
        public string DocNo { get; set; }

        [StringLength(20)]
        public string Ref { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? InvoiceDate { get; set; }

        [StringLength(80)]
        public string DocHT { get; set; }

        [StringLength(20)]
        public string ST { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EntryDate { get; set; }

        [StringLength(20)]
        public string At1 { get; set; }

        public decimal? Invoice { get; set; }

        [StringLength(20)]
        public string At2 { get; set; }

        public decimal? VAT { get; set; }

        [StringLength(20)]
        public string At3 { get; set; }

        public decimal? PAY { get; set; }

        [StringLength(11)]
        public string VendorID { get; set; }

        [StringLength(80)]
        public string VendorName { get; set; }

        [StringLength(11)]
        public string PayeeID { get; set; }

        [StringLength(150)]
        public string PayeeName { get; set; }

        [StringLength(10)]
        public string RT { get; set; }

        public decimal? Percent1 { get; set; }

        public decimal? WHT1 { get; set; }

        public decimal? Percent2 { get; set; }

        public decimal? WHT2 { get; set; }

        public decimal? Percent3 { get; set; }

        public decimal? WHT3 { get; set; }

        public int? PVSAPID { get; set; }
    }
}
