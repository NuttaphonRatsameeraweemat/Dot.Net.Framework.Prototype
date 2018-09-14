namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.WorkflowDelegate")]
    public partial class WorkflowDelegate
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string FromUser { get; set; }

        [StringLength(100)]
        public string ToUser { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }
    }
}
