namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.HREmployeeMobile")]
    public partial class HREmployeeMobile
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string EmpNo { get; set; }

        [StringLength(20)]
        public string MobileNo { get; set; }

        [StringLength(11)]
        public string CreateBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }
    }
}
