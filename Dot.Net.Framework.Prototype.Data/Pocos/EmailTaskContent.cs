namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.EmailTaskContent")]
    public partial class EmailTaskContent
    {
        public int ID { get; set; }

        public int EmailTaskID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
