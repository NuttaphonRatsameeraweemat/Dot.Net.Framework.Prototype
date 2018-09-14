namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.UserRole")]
    public partial class UserRole
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Username { get; set; }

        public int? CompositeRoleID { get; set; }

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
