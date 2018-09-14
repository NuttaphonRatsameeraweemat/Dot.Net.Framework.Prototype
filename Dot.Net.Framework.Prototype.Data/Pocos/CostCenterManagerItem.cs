namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.CostCenterManagerItem")]
    public partial class CostCenterManagerItem
    {
        public int ID { get; set; }

        public int? CostCenterManagerID { get; set; }

        [StringLength(11)]
        public string Manager { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }
    }
}
