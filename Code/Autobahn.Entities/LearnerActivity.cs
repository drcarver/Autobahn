using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LearnerActivity")]
    public partial class LearnerActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LearnerActivity()
        {
            LearnerActivity_LearningResource = new HashSet<LearnerActivity_LearningResource>();
        }

        public int LearnerActivityId { get; set; }

        public int PersonId { get; set; }

        public int? AssessmentRegistrationId { get; set; }

        public int? CourseSectionId { get; set; }

        public int? OrganizationCalendarSessionId { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(300)]
        public string Prerequisite { get; set; }

        public int? RefLearnerActivityTypeId { get; set; }

        [StringLength(512)]
        public string RubricUrl { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreationDate { get; set; }

        public decimal? MaximumTimeAllowed { get; set; }

        public int? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public TimeSpan? DueTime { get; set; }

        public decimal? MaximumAttemptsAllowed { get; set; }

        public int? RefLearnerActivityAddToGradeBookFlagId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }

        public decimal? Weight { get; set; }

        public decimal? PossiblePoints { get; set; }

        public int? RefLanguageId { get; set; }

        public int? AssignedByPersonId { get; set; }

        public int? SchoolOrganizationId { get; set; }

        public int? LeaOrganizationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentRegistration AssessmentRegistration { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Organization Organization1 { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }

        public virtual Person Person { get; set; }

        public virtual Person Person1 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLearnerActivityMaximumTimeAllowedUnit RefLearnerActivityMaximumTimeAllowedUnit { get; set; }

        public virtual RefLearnerActivityType RefLearnerActivityType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity_LearningResource> LearnerActivity_LearningResource { get; set; }
    }
}
