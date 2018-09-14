namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.HRPosition")]
    public partial class HRPosition
    {
        [Key]
        [StringLength(8)]
        public string PosID { get; set; }

        [StringLength(40)]
        public string PosName { get; set; }

        [StringLength(6)]
        public string PosLevel { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastInterface { get; set; }
    }
}
