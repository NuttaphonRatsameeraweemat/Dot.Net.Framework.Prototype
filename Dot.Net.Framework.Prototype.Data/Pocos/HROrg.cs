namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.HROrg")]
    public partial class HROrg
    {
        [Key]
        [StringLength(8)]
        public string OrgID { get; set; }

        [StringLength(100)]
        public string OrgName { get; set; }

        [StringLength(100)]
        public string ManagerEmpNo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastInterface { get; set; }

        [StringLength(11)]
        public string OrgLevel { get; set; }
    }
}
