namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.HRBusinessPlace")]
    public partial class HRBusinessPlace
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string BusinessPlace { get; set; }

        [StringLength(100)]
        public string BusinessPlaceName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ComCode { get; set; }
    }
}
