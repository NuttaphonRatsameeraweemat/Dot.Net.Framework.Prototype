namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.CompanyManager")]
    public partial class CompanyManager
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }

        [StringLength(10)]
        public string Status { get; set; }
    }
}
