namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.UserPostal")]
    public partial class UserPostal
    {
        [Key]
        [StringLength(11)]
        public string EmpNo { get; set; }

        [Required]
        [StringLength(100)]
        public string UserKey { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreateDate { get; set; }
    }
}
