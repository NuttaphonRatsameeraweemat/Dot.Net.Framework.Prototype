namespace Dot.Net.Framework.Prototype.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Pocos;
    using System.Data.SqlClient;

    public partial class DSDBContext : DbContext
    {
        private readonly string _defaultSchema;

        public DSDBContext(string connectionString, string defaultSchema = null)
            : base(new SqlConnection(connectionString), true)
        {
            _defaultSchema = defaultSchema;
        }

        public virtual DbSet<AppCompositeRole> AppCompositeRoles { get; set; }
        public virtual DbSet<AppCompositeRoleItem> AppCompositeRoleItems { get; set; }
        public virtual DbSet<AppDocumentNo> AppDocumentNoes { get; set; }
        public virtual DbSet<AppLog> AppLogs { get; set; }
        public virtual DbSet<AppMenu> AppMenus { get; set; }
        public virtual DbSet<AppSingleRole> AppSingleRoles { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<AuthorityCompany> AuthorityCompanies { get; set; }
        public virtual DbSet<BoardUser> BoardUsers { get; set; }
        public virtual DbSet<B> BS { get; set; }
        public virtual DbSet<BSCompany> BSCompanies { get; set; }
        public virtual DbSet<BSPayee> BSPayees { get; set; }
        public virtual DbSet<BSSigner> BSSigners { get; set; }
        public virtual DbSet<CA> CAs { get; set; }
        public virtual DbSet<CAReceive> CAReceives { get; set; }
        public virtual DbSet<CompanyBankInfo> CompanyBankInfoes { get; set; }
        public virtual DbSet<CompanyManager> CompanyManagers { get; set; }
        public virtual DbSet<CompanyManagerItem> CompanyManagerItems { get; set; }
        public virtual DbSet<ConfigureValue> ConfigureValues { get; set; }
        public virtual DbSet<ConnectionLog> ConnectionLogs { get; set; }
        public virtual DbSet<CostCenter> CostCenters { get; set; }
        public virtual DbSet<CostCenterManager> CostCenterManagers { get; set; }
        public virtual DbSet<CostCenterManagerItem> CostCenterManagerItems { get; set; }
        public virtual DbSet<EmailTask> EmailTasks { get; set; }
        public virtual DbSet<EmailTaskContent> EmailTaskContents { get; set; }
        public virtual DbSet<EmailTaskReceiver> EmailTaskReceivers { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<ExecutiveUser> ExecutiveUsers { get; set; }
        public virtual DbSet<HolidayCalendar> HolidayCalendars { get; set; }
        public virtual DbSet<HRBusinessPlace> HRBusinessPlaces { get; set; }
        public virtual DbSet<HRCompany> HRCompanies { get; set; }
        public virtual DbSet<HREmployee> HREmployees { get; set; }
        public virtual DbSet<HREmployeeMobile> HREmployeeMobiles { get; set; }
        public virtual DbSet<HROrg> HROrgs { get; set; }
        public virtual DbSet<HROrgRelation> HROrgRelations { get; set; }
        public virtual DbSet<HRPosition> HRPositions { get; set; }
        public virtual DbSet<OTP> OTPs { get; set; }
        public virtual DbSet<PV> PVs { get; set; }
        public virtual DbSet<PVActivitySAP> PVActivitySAPs { get; set; }
        public virtual DbSet<PVGroup> PVGroups { get; set; }
        public virtual DbSet<PVGroupItem> PVGroupItems { get; set; }
        public virtual DbSet<PVItem> PVItems { get; set; }
        public virtual DbSet<PVItemSAP> PVItemSAPs { get; set; }
        public virtual DbSet<PVSAP> PVSAPs { get; set; }
        public virtual DbSet<RespGroup> RespGroups { get; set; }
        public virtual DbSet<RespGroupAdmin> RespGroupAdmins { get; set; }
        public virtual DbSet<RespGroupComp> RespGroupComps { get; set; }
        public virtual DbSet<RespGroupEmp> RespGroupEmps { get; set; }
        public virtual DbSet<RespGroupOrg> RespGroupOrgs { get; set; }
        public virtual DbSet<ReviewManager> ReviewManagers { get; set; }
        public virtual DbSet<ReviewManagerItem> ReviewManagerItems { get; set; }
        public virtual DbSet<UserPostal> UserPostals { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<ValueHelp> ValueHelps { get; set; }
        public virtual DbSet<WorkflowActivityLog> WorkflowActivityLogs { get; set; }
        public virtual DbSet<WorkflowActivityStep> WorkflowActivitySteps { get; set; }
        public virtual DbSet<WorkflowDelegate> WorkflowDelegates { get; set; }
        public virtual DbSet<WorkflowProcess> WorkflowProcesses { get; set; }
        public virtual DbSet<WorkflowProcessInstance> WorkflowProcessInstances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Sets default schema if any.
            if (!String.IsNullOrEmpty(_defaultSchema))
            {
                modelBuilder.HasDefaultSchema(_defaultSchema);
            }

            modelBuilder.Entity<Authority>()
                .Property(e => e.Remark1)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Authority>()
                .Property(e => e.Remark2)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Authority>()
                .Property(e => e.Remark3)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Authority>()
                .Property(e => e.Remark4)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Authority>()
                .Property(e => e.Remark5)
                .HasPrecision(20, 4);

            modelBuilder.Entity<BSCompany>()
                .Property(e => e.DebitAmount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<BSPayee>()
                .Property(e => e.Amount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<CA>()
                .Property(e => e.Amount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.Amount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.VAT)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.WHT)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.TotalAmount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.CAAmount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.NetAmount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.TotalInvoice)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.TotalVAT)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.TotalPay)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.TotalWHT1)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.TotalWHT2)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PV>()
                .Property(e => e.TotalWHT3)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.Invoice)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.VAT)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.PAY)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.Percent1)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.WHT1)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.Percent2)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.WHT2)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.Percent3)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItem>()
                .Property(e => e.WHT3)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.Invoice)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.VAT)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.PAY)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.Percent1)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.WHT1)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.Percent2)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.WHT2)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.Percent3)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVItemSAP>()
                .Property(e => e.WHT3)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.Amount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.VAT)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.WHT)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.TotalAmount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.CAAmount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.NetAmount)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.TotalInvoice)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.TotalVAT)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.TotalPay)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.TotalWHT1)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.TotalWHT2)
                .HasPrecision(20, 4);

            modelBuilder.Entity<PVSAP>()
                .Property(e => e.TotalWHT3)
                .HasPrecision(20, 4);
        }
    }
}
