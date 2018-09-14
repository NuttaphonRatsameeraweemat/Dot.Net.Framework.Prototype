namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.RespGroup")]
    public partial class RespGroup
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public string Remark { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }

        public bool BudgetGroup { get; set; }

        [StringLength(20)]
        public string GroupType { get; set; }
    }
}
