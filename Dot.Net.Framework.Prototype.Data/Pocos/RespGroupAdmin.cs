namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.RespGroupAdmin")]
    public partial class RespGroupAdmin
    {
        public int ID { get; set; }

        public int? RespGroupID { get; set; }

        [StringLength(11)]
        public string EmpNo { get; set; }
    }
}
