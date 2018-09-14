namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.CAReceive")]
    public partial class CAReceive
    {
        public int ID { get; set; }

        [StringLength(15)]
        public string CANo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CAReceiveDate { get; set; }

        [StringLength(20)]
        public string TitleTH { get; set; }

        [StringLength(80)]
        public string FirstNameTH { get; set; }

        [StringLength(80)]
        public string MiddleNameTH { get; set; }

        [StringLength(80)]
        public string LastNameTH { get; set; }

        [StringLength(20)]
        public string TitleEN { get; set; }

        [StringLength(20)]
        public string FirstNameEN { get; set; }

        [StringLength(80)]
        public string MiddleNameEN { get; set; }

        [StringLength(80)]
        public string LastNameEN { get; set; }

        [StringLength(80)]
        public string No { get; set; }

        [StringLength(80)]
        public string Moo { get; set; }

        [StringLength(80)]
        public string Trok { get; set; }

        [StringLength(80)]
        public string Soi { get; set; }

        [StringLength(80)]
        public string Tanon { get; set; }

        [StringLength(80)]
        public string Tambon { get; set; }

        [StringLength(80)]
        public string Amper { get; set; }

        [StringLength(80)]
        public string Jangwat { get; set; }

        [StringLength(80)]
        public string ExpiryDate { get; set; }

        [StringLength(80)]
        public string Photo { get; set; }
    }
}
