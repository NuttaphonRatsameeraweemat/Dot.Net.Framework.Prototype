namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.Attachment")]
    public partial class Attachment
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string ProcessCode { get; set; }

        [StringLength(100)]
        public string DataKey { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        public int? FileSize { get; set; }

        [StringLength(200)]
        public string MimeType { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AttachDate { get; set; }

        [StringLength(100)]
        public string AttachBy { get; set; }

        [StringLength(200)]
        public string SavedFileName { get; set; }

        [StringLength(100)]
        public string FileExtension { get; set; }

        [StringLength(100)]
        public string FileUniqueKey { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DocumentDate { get; set; }

        [StringLength(20)]
        public string DocumentType { get; set; }

        public string Remark { get; set; }

        [StringLength(100)]
        public string AttachmentGroup { get; set; }
    }
}
