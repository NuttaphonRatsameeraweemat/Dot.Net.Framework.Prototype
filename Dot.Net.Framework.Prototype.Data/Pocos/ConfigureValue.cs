namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.ConfigureValue")]
    public partial class ConfigureValue
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Key { get; set; }

        public string Description { get; set; }

        [StringLength(40)]
        public string Value { get; set; }
    }
}
