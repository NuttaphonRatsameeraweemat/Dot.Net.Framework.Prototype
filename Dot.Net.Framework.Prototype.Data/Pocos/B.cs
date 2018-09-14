namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.BS")]
    public partial class B
    {
        public int ID { get; set; }

        [StringLength(16)]
        public string BSNo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BSDate { get; set; }

        [StringLength(12)]
        public string BankCode { get; set; }

        [StringLength(10)]
        public string ProductCode { get; set; }

        public string To { get; set; }

        public string Topic { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

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

        public string TopicDate { get; set; }

        public string TopicDetail { get; set; }
    }
}
