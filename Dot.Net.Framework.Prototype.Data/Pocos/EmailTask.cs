namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.EmailTask")]
    public partial class EmailTask
    {
        public int ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TaskDate { get; set; }

        [Required]
        [StringLength(4)]
        public string TaskCode { get; set; }

        [Required]
        [StringLength(40)]
        public string TaskBy { get; set; }

        [Required]
        [StringLength(20)]
        public string DocNo { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
