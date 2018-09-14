namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.AppSingleRole")]
    public partial class AppSingleRole
    {
        [Key]
        [StringLength(100)]
        public string RoleID { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
    }
}
