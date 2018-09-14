namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.ConnectionLog")]
    public partial class ConnectionLog
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string LogType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LogDate { get; set; }

        [StringLength(100)]
        public string User { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        [StringLength(20)]
        public string Browser { get; set; }

        public string UserAgent { get; set; }

        [StringLength(20)]
        public string BrowserVersion { get; set; }

        [StringLength(20)]
        public string BrowserType { get; set; }

        public bool? IsMobile { get; set; }

        [StringLength(30)]
        public string MobileModel { get; set; }

        [StringLength(30)]
        public string MobileManufacturer { get; set; }

        [StringLength(50)]
        public string DocumentNo { get; set; }
    }
}
