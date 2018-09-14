namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.RespGroupEmp")]
    public partial class RespGroupEmp
    {
        public int ID { get; set; }

        public int? RespGroupID { get; set; }

        [StringLength(11)]
        public string EmpNo { get; set; }
    }
}
