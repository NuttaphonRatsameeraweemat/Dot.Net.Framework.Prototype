namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.RespGroupOrg")]
    public partial class RespGroupOrg
    {
        public int ID { get; set; }

        public int? RespGroupID { get; set; }

        [StringLength(8)]
        public string OrgID { get; set; }
    }
}
