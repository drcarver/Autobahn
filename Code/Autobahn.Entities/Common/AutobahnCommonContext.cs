//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   AutobahnCommonContext.cs
//**********************************************************

using Microsoft.EntityFrameworkCore;

namespace Autobahn.Entities.Common
{
    public partial class AutobahnCommonContext : DbContext
    {
        public AutobahnCommonContext()
        {
        }

        public AutobahnCommonContext(DbContextOptions<AutobahnCommonContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"DataSource=C:\Users\drcarver\Desktop\codegen\Autobahn\Code\Autobahn.Codegen\Reference\Autobahn.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        /// <summary>
        /// An activity, such as a co-curricular or extra-curricular
        /// activity that is offered at an education institution.
        /// </summary>
        public DbSet<Activity> Activity { get; set; }

        public DbSet<DataCollection> DataCollection { get; set; }

        /// <summary>
        /// An organized body of people with a particular
        /// purpose, especially a business, society,
        /// association, etc.:
        /// </summary>
        public DbSet<Organization> Organization { get; set; }

        public DbSet<OrganizationWebsite> OrganizationWebsite { get; set; }

        public DbSet<Person> Person { get; set; }

        public DbSet<PersonMaster> PersonMaster { get; set; }

        public DbSet<RecordStatus> RecordStatus { get; set; }

        public DbSet<RefAbsentAttendanceCategory> RefAbsentAttendanceCategory { get; set; }

        public DbSet<RefAttendanceEventType> RefAttendanceEventType { get; set; }

        public DbSet<RefAttendanceStatus> RefAttendanceStatus { get; set; }

        public DbSet<RefCountry> RefCountry { get; set; }

        public DbSet<RefLeaveEventType> RefLeaveEventType { get; set; }

        public DbSet<RefPresentAttendanceCategory> RefPresentAttendanceCategory { get; set; }

        /// <summary>
        /// The type of entity that created or indicated the Record Status Type
        /// </summary>
        public DbSet<RefRecordStatusCreatorEntity> RefRecordStatusCreatorEntity { get; set; }

        /// <summary>
        /// A process indicator of the level of stability, quality, and/or preparedness of the record.
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermxTopicId=57529">Record Status Type</a>
        /// </summary>
        public DbSet<RefRecordStatusType> RefRecordStatusType { get; set; }

        public DbSet<RefRole> RefRole { get; set; }

        public DbSet<Role> Role { get; set; }

        private DbSet<RoleAttendanceEvent> RoleAttendanceEvent { get; set; }
    }
}
