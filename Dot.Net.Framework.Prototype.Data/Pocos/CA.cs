namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.CA")]
    public partial class CA
    {
        public int ID { get; set; }

        [StringLength(15)]
        public string CANo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CADate { get; set; }

        [StringLength(25)]
        public string FundSAP { get; set; }

        [StringLength(25)]
        public string IOSAP { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }

        [StringLength(10)]
        public string CostCenter { get; set; }

        [StringLength(20)]
        public string ReserveBudget { get; set; }

        [StringLength(50)]
        public string InternalMemoNo { get; set; }

        [StringLength(80)]
        public string Objective { get; set; }

        public string ObjectiveDesc { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(3)]
        public string Currency { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RequireDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ReceiveDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DueDate { get; set; }

        [StringLength(13)]
        public string ReceiveID { get; set; }

        [StringLength(20)]
        public string BusinessPlace { get; set; }

        [StringLength(20)]
        public string PaymentPlace { get; set; }

        public string Remark { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(11)]
        public string PrepareBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RequestDate { get; set; }

        [StringLength(11)]
        public string RequestFor { get; set; }

        [StringLength(9)]
        public string RequestPos { get; set; }

        [StringLength(9)]
        public string RequestOrg { get; set; }

        [StringLength(11)]
        public string CreateBy { get; set; }

        [StringLength(9)]
        public string CreatePos { get; set; }

        [StringLength(9)]
        public string CreateOrg { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }

        [StringLength(11)]
        public string LastModifyBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastModifyDate { get; set; }

        public string SAPMessage { get; set; }

        [StringLength(2)]
        public string ReceiveType { get; set; }

        public bool? Executive { get; set; }

        public string ReceiveRemark { get; set; }
    }
}
