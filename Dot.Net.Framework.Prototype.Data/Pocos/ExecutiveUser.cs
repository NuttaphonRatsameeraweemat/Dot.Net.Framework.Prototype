namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.ExecutiveUser")]
    public partial class ExecutiveUser
    {
        public int ID { get; set; }

        [StringLength(11)]
        public string CreateBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }

        [StringLength(40)]
        public string ADUser { get; set; }

        public bool? NoReport { get; set; }
    }
}
