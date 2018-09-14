namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.ValueHelp")]
    public partial class ValueHelp
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string ValueType { get; set; }

        [Required]
        [StringLength(20)]
        public string ValueKey { get; set; }

        [StringLength(100)]
        public string ValueText { get; set; }

        public int? Sequence { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string CreateBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastModifyDate { get; set; }

        [StringLength(100)]
        public string LastModifyBy { get; set; }
    }
}
