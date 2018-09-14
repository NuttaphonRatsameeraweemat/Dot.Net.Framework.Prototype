namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.HolidayCalendar")]
    public partial class HolidayCalendar
    {
        public int ID { get; set; }

        public short? Year { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? HolidayDate { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string CreateBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastModifyDate { get; set; }

        [StringLength(100)]
        public string LastModifyBy { get; set; }

        public bool? PublicHoliday { get; set; }
    }
}
