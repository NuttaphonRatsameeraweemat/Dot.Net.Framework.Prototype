namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.PVGroup")]
    public partial class PVGroup
    {
        public int ID { get; set; }

        [StringLength(12)]
        public string PVGroupNo { get; set; }

        [StringLength(20)]
        public string PVGroupType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PVGroupDate { get; set; }

        public string Remark { get; set; }

        [StringLength(11)]
        public string CreateBy { get; set; }

        [StringLength(11)]
        public string CreatePos { get; set; }

        [StringLength(11)]
        public string CreateOrg { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string OrgName { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }
    }
}
