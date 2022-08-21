//**********************************************************
//* DomainName: Autobahn.LearningResources
//* FileName:   LearnerActivity.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Assessments;
using Autobahn.Entities.Common;

namespace Autobahn.Entities.LearningResources
{
    [Table("LearnerActivity", Schema= "LearningResources")]
    public partial class LearnerActivity : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LearnerActivity()
        {
            LearnerActivityLearningResource = new HashSet<LearnerActivityLearningResource>();
        }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        [ForeignKey("AssessmentRegistration")]
        public Guid? AssessmentRegistrationId { get; set; }

        [ForeignKey("CourseSection")]
        public Guid? CourseSectionId { get; set; }

        [ForeignKey("OrganizationCalendarSession")]
        public Guid? OrganizationCalendarSessionId { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(300)]
        public string Prerequisite { get; set; }

        [ForeignKey("RefLearnerActivityType")]
        public Guid? RefLearnerActivityTypeId { get; set; }

        [StringLength(512)]
        public string RubricUrl { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreationDate { get; set; }

        public decimal? MaximumTimeAllowed { get; set; }

        [ForeignKey("RefLearnerActivityMaximumTimeAllowedUnit")]
        public Guid? RefLearnerActivityMaximumTimeAllowedUnitId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public TimeSpan? DueTime { get; set; }

        public decimal? MaximumAttemptsAllowed { get; set; }

        [ForeignKey("RefLearnerActivityAddToGradeBookFlag")]
        public Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }

        public decimal? Weight { get; set; }

        public decimal? PossiblePoints { get; set; }

        [ForeignKey("RefLanguage")]
        public Guid? RefLanguageId { get; set; }

        [ForeignKey("Person")]
        public Guid? AssignedByPersonId { get; set; }

        [ForeignKey("Organization")]
        public Guid? SchoolOrganizationId { get; set; }

        [ForeignKey("Organization")]
        public Guid? LeaOrganizationId { get; set; }

        public virtual AssessmentRegistration AssessmentRegistration { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual Organization LeaOrganization { get; set; }

        public virtual Organization SchoolOrganization { get; set; }

        public virtual OrganizationCalendarSession OrganizationCalendarSession { get; set; }

        public virtual Person Person { get; set; }

        public virtual Person AssignedByPerson { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        public virtual RefLearnerActivityMaximumTimeAllowedUnit RefLearnerActivityMaximumTimeAllowedUnit { get; set; }

        public virtual RefLearnerActivityAddToGradeBookFlag RefLearnerActivityAddToGradeBookFlag { get; set; }

        public virtual RefLearnerActivityType RefLearnerActivityType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivityLearningResource> LearnerActivityLearningResource { get; set; }
    }
}
