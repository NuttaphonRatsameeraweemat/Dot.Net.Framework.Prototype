namespace Dot.Net.Framework.Prototype.Data.Pocos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ds.HREmployee")]
    public partial class HREmployee
    {
        [Key]
        [StringLength(11)]
        public string EmpNo { get; set; }

        [StringLength(20)]
        public string TitleTH { get; set; }

        [StringLength(60)]
        public string FirstnameTH { get; set; }

        [StringLength(60)]
        public string LastnameTH { get; set; }

        [StringLength(15)]
        public string TitleEN { get; set; }

        [StringLength(60)]
        public string FirstnameEN { get; set; }

        [StringLength(60)]
        public string LastnameEN { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string ADUser { get; set; }

        [StringLength(100)]
        public string MobileNo { get; set; }

        [StringLength(100)]
        public string OfficeTel { get; set; }

        [StringLength(30)]
        public string IDCard { get; set; }

        [StringLength(1)]
        public string EmpStatus { get; set; }

        [StringLength(5)]
        public string GradeCode { get; set; }

        [StringLength(60)]
        public string GradeText { get; set; }

        [StringLength(9)]
        public string PositionID { get; set; }

        [StringLength(9)]
        public string OrgID { get; set; }

        [StringLength(100)]
        public string ManagerEmpNo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastInterface { get; set; }

        [StringLength(10)]
        public string ComCode { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BirthDate { get; set; }
    }
}
