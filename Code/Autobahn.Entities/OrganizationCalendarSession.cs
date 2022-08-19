using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationCalendarSession")]
    public partial class OrganizationCalendarSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationCalendarSession()
        {
            CourseSections = new HashSet<CourseSection>();
            K12FederalFundAllocation = new HashSet<K12FederalFundAllocation>();
            K12LeaFederalFunds = new HashSet<K12LeaFederalFunds>();
            K12StudentSession = new HashSet<K12StudentSession>();
            LearnerActivities = new HashSet<LearnerActivity>();
            OrganizationFinancials = new HashSet<OrganizationFinancial>();
        }

        public int OrganizationCalendarSessionId { get; set; }

        [StringLength(7)]
        public string Designator { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BeginDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public int? RefSessionTypeId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InstructionalMinutes { get; set; }

        [StringLength(30)]
        public string Code { get; set; }

        public string Description { get; set; }

        public bool? MarkingTermIndicator { get; set; }

        public bool? SchedulingTermIndicator { get; set; }

        public bool? AttendanceTermIndicator { get; set; }

        public int? OrganizationCalendarId { get; set; }

        public int? DaysInSession { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FirstInstructionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastInstructionDate { get; set; }

        public int? MinutesPerDay { get; set; }

        public TimeSpan? SessionStartTime { get; set; }

        public TimeSpan? SessionEndTime { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RefAcademicTermDesignatorId { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSection> CourseSections { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12FederalFundAllocation> K12FederalFundAllocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12LeaFederalFunds> K12LeaFederalFunds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12StudentSession> K12StudentSession { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }

        public virtual OrganizationCalendar OrganizationCalendar { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAcademicTermDesignator RefAcademicTermDesignator { get; set; }

        public virtual RefSessionType RefSessionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationFinancial> OrganizationFinancials { get; set; }
    }
}
