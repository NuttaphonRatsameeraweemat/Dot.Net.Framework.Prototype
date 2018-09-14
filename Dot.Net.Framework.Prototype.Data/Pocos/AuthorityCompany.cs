namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.AuthorityCompany")]
    public partial class AuthorityCompany
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string ADUser { get; set; }

        public bool? BRB { get; set; }

        public bool? BRT { get; set; }

        public bool? SCO { get; set; }

        [StringLength(11)]
        public string CreateBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }
    }
}
