namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.PVActivitySAP")]
    public partial class PVActivitySAP
    {
        public int ID { get; set; }

        [StringLength(12)]
        public string PVNo { get; set; }

        public int? ProcessInstanceID { get; set; }

        [StringLength(16)]
        public string Step { get; set; }

        [StringLength(100)]
        public string Activity { get; set; }

        [StringLength(100)]
        public string ActionID { get; set; }

        [StringLength(10)]
        public string ActionType { get; set; }

        [StringLength(100)]
        public string Action { get; set; }

        [StringLength(100)]
        public string ActionName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ActionDate { get; set; }

        public string Comment { get; set; }

        [StringLength(100)]
        public string AllocateUser { get; set; }

        public int? PVSAPID { get; set; }
    }
}
