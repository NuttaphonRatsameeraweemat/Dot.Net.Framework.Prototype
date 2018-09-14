namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.HROrgRelation")]
    public partial class HROrgRelation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string ParentOrgID { get; set; }

        [StringLength(40)]
        public string ParentOrgName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string ChildOrgID { get; set; }

        [StringLength(40)]
        public string ChildOrgName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastInterface { get; set; }
    }
}
