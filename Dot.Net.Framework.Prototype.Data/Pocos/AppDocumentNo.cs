namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.AppDocumentNo")]
    public partial class AppDocumentNo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string ProcessCode { get; set; }

        [StringLength(50)]
        public string DocumentNoPrefix { get; set; }

        public int? LastRunningNo { get; set; }

        public int? RunningNoDigit { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Year { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Additional01 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Additional02 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string Additional03 { get; set; }
    }
}
