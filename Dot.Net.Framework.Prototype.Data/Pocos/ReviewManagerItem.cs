namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.ReviewManagerItem")]
    public partial class ReviewManagerItem
    {
        public int ID { get; set; }

        public int? ReviewManagerID { get; set; }

        [StringLength(11)]
        public string Reviewer { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }
    }
}
