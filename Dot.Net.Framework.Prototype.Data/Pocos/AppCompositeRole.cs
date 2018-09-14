namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.AppCompositeRole")]
    public partial class AppCompositeRole
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string CreateBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastModifyDate { get; set; }

        [StringLength(100)]
        public string LastModifyBy { get; set; }
    }
}
