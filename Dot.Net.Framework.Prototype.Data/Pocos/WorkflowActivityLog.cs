namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.WorkflowActivityLog")]
    public partial class WorkflowActivityLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessInstanceID { get; set; }

        public int? Step { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string SerialNo { get; set; }

        [StringLength(100)]
        public string ActionUser { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ActionDate { get; set; }

        [StringLength(100)]
        public string Action { get; set; }

        public string Comment { get; set; }

        [StringLength(100)]
        public string AllocatedUser { get; set; }

        [StringLength(11)]
        public string ActionUserCode { get; set; }

        [StringLength(9)]
        public string ActionUserPosition { get; set; }

        [StringLength(9)]
        public string ActionUserOrg { get; set; }
    }
}
