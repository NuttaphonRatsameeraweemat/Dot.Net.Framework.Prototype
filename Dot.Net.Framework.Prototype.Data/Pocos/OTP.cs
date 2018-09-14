namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.OTP")]
    public partial class OTP
    {
        public int ID { get; set; }

        [StringLength(11)]
        public string EmpNo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CommitDate { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(20)]
        public string MobileNo { get; set; }
    }
}
