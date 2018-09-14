namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.PVGroupItem")]
    public partial class PVGroupItem
    {
        public int ID { get; set; }

        [StringLength(12)]
        public string PVGroupNo { get; set; }

        [StringLength(12)]
        public string PVNo { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }
    }
}
