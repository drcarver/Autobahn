//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLocation.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Assessments;
using Autobahn.Entities.LearningResources;
using Autobahn.Interfaces.Common;

namespace Autobahn.Entities.Common
{
    [Table("CourseSection", Schema = "Common")]
    public partial class CourseSection : EntityBase, ICourseSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseSection()
        {
            AssessmentRegistrations = new HashSet<AssessmentRegistration>();
            CourseSectionAssessmentReportings = new HashSet<CourseSectionAssessmentReporting>();
            CourseSectionLevels = new HashSet<CourseSectionLevel>();
            CourseSectionLocations = new HashSet<CourseSectionLocation>();
            CourseSectionSchedules = new HashSet<CourseSectionSchedule>();
            LearnerActivities = new HashSet<LearnerActivity>();
            PsSections = new HashSet<PsSection>();
        }

        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set; }

        [ForeignKey("Course")]
        public Guid CourseId { get; set; }

        public decimal? AvailableCarnegieUnitCredit { get; set; }

        public decimal? TimeRequiredForCompletion { get; set; }

        public bool? VirtualIndicator { get; set; }

        [ForeignKey("OrganizationCalendarSession")]
        public Guid? OrganizationCalendarSessionId { get; set; }

        public int? MaximumCapacity { get; set; }

        [StringLength(60)]
        public string RelatedCompetencyDefinitions { get; set; }

        [ForeignKey("RefCourseSectionDeliveryMode")]
        public Guid? RefCourseSectionDeliveryModeId { get; set; }

        [ForeignKey("RefSingleSexClassStatus")]
        public Guid? RefSingleSexClassStatusId { get; set; }

        [ForeignKey("RefAdditionalCreditType")]
        public Guid? RefAdditionalCreditTypeId { get; set; }

        [ForeignKey("RefInstructionLanguage")]
        public Guid? RefInstructionLanguageId { get; set; }

        [ForeignKey("RefCreditTypeEarned")]
        public Guid? RefCreditTypeEarnedId { get; set; }

        [ForeignKey("RefAdvancedPlacementCourseCode")]
        public Guid? RefAdvancedPlacementCourseCodeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }

        public virtual Course Course { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }

        public virtual RefAdvancedPlacementCourseCode RefAdvancedPlacementCourseCode { get; set; }

        public virtual RefCourseSectionDeliveryMode RefCourseSectionDeliveryMode { get; set; }

        public virtual RefSingleSexClassStatus RefSingleSexClassStatus { get; set; }

        public virtual RefCreditTypeEarned RefCreditTypeEarned { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSectionAssessmentReporting> CourseSectionAssessmentReportings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSectionLevel> CourseSectionLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSectionLocation> CourseSectionLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSectionSchedule> CourseSectionSchedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsSection> PsSections { get; set; }
    }
}
