namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.BSSigner")]
    public partial class BSSigner
    {
        public int ID { get; set; }

        [StringLength(11)]
        public string Signer { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }
    }
}
