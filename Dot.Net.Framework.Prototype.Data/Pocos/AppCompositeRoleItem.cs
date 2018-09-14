namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.AppCompositeRoleItem")]
    public partial class AppCompositeRoleItem
    {
        public int ID { get; set; }

        public int? CompositeRoleID { get; set; }

        [StringLength(100)]
        public string RoleID { get; set; }
    }
}
