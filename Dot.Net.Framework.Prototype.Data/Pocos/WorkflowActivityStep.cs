namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.WorkflowActivityStep")]
    public partial class WorkflowActivityStep
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessInstanceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Step { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string ActionUser { get; set; }

        [StringLength(20)]
        public string Activity { get; set; }

        [StringLength(20)]
        public string FormState { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [StringLength(11)]
        public string ActionUserCode { get; set; }

        [StringLength(9)]
        public string ActionUserPosition { get; set; }

        [StringLength(9)]
        public string ActionUserOrg { get; set; }
    }
}
