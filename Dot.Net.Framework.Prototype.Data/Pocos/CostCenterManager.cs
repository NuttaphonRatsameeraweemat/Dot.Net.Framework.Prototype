namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.CostCenterManager")]
    public partial class CostCenterManager
    {
        public int ID { get; set; }

        [StringLength(11)]
        public string CostCenter { get; set; }

        [StringLength(10)]
        public string Status { get; set; }
    }
}
