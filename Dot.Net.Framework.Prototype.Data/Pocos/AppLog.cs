namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.AppLog")]
    public partial class AppLog
    {
        public int ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LogDate { get; set; }

        [StringLength(200)]
        public string LogBy { get; set; }

        [StringLength(200)]
        public string Method { get; set; }

        public string Message { get; set; }

        public string Data1 { get; set; }

        public string Data2 { get; set; }
    }
}
