using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CourseSection")]
    public partial class CourseSection
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

        public int CourseSectionId { get; set; }

        public int OrganizationId { get; set; }

        public int CourseId { get; set; }

        public decimal? AvailableCarnegieUnitCredit { get; set; }

        public decimal? TimeRequiredForCompletion { get; set; }

        public bool? VirtualIndicator { get; set; }

        public int? OrganizationCalendarSessionId { get; set; }

        public int? MaximumCapacity { get; set; }

        [StringLength(60)]
        public string RelatedCompetencyDefinitions { get; set; }

        public int? RefCourseSectionDeliveryModeId { get; set; }

        public int? RefSingleSexClassStatusId { get; set; }

        public int? RefAdditionalCreditTypeId { get; set; }

        public int? RefInstructionLanguageId { get; set; }

        public int? RefCreditTypeEarnedId { get; set; }

        public int? RefAdvancedPlacementCourseCodeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }

        public virtual Course Course { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdvancedPlacementCourseCode RefAdvancedPlacementCourseCode { get; set; }

        public virtual RefCourseSectionDeliveryMode RefCourseSectionDeliveryMode { get; set; }

        public virtual RefSingleSexClassStatu RefSingleSexClassStatu { get; set; }

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
