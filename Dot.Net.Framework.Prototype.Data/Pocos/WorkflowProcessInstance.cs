namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.WorkflowProcessInstance")]
    public partial class WorkflowProcessInstance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProcessInstanceID { get; set; }

        [StringLength(100)]
        public string ProcessCode { get; set; }

        public int? DataID { get; set; }

        public int? CurrentStep { get; set; }

        [StringLength(20)]
        public string Status { get; set; }
    }
}
