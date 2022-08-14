using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentRegistration")]
    public partial class AssessmentRegistration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentRegistration()
        {
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            AssessmentRegistrationAccommodation = new HashSet<AssessmentRegistrationAccommodation>();
            AssessmentResults = new HashSet<AssessmentResult>();
            LearnerActivities = new HashSet<LearnerActivity>();
        }

        public int AssessmentRegistrationId { get; set; }

        public int PersonId { get; set; }

        public int AssessmentFormId { get; set; }

        public DateTime? CreationDate { get; set; }

        public int? DaysOfInstructionPriorToAssessment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ScorePublishDate { get; set; }

        [StringLength(40)]
        public string TestAttemptIdentifier { get; set; }

        public bool? RetestIndicator { get; set; }

        public int? CourseSectionId { get; set; }

        [StringLength(300)]
        public string TestingIndicator { get; set; }

        public int? OrganizationId { get; set; }

        public int? SchoolOrganizationId { get; set; }

        public int? LeaOrganizationId { get; set; }

        public int? AssessmentAdministrationId { get; set; }

        public int? AssignedByPersonId { get; set; }

        public DateTime? AssessmentRegistrationCompletionStatusDateTime { get; set; }

        public bool? StateFullAcademicYear { get; set; }

        public bool? LEAFullAcademicYear { get; set; }

        public bool? SchoolFullAcademicYear { get; set; }

        public int? RefAssessmentParticipationIndicatorId { get; set; }

        public int? RefAssessmentPurposeId { get; set; }

        public int? RefAssessmentReasonNotTestedId { get; set; }

        public int? RefAssessmentReasonNotCompletingId { get; set; }

        public int? RefGradeLevelToBeAssessedId { get; set; }

        public int? RefGradeLevelWhenAssessedId { get; set; }

        public int? RefAssessmentRegistrationCompletionStatusId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual AssessmentAdministration AssessmentAdministration { get; set; }

        public virtual AssessmentForm AssessmentForm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Person Person { get; set; }

        public virtual Person Person1 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentParticipationIndicator RefAssessmentParticipationIndicator { get; set; }

        public virtual RefAssessmentPurpose RefAssessmentPurpose { get; set; }

        public virtual RefAssessmentReasonNotCompleting RefAssessmentReasonNotCompleting { get; set; }

        public virtual RefAssessmentReasonNotTested RefAssessmentReasonNotTested { get; set; }

        public virtual RefAssessmentRegistrationCompletionStatus RefAssessmentRegistrationCompletionStatus { get; set; }

        public virtual RefGradeLevel RefGradeLevel { get; set; }

        public virtual RefGradeLevel RefGradeLevel1 { get; set; }

        public virtual Organization Organization1 { get; set; }

        public virtual Organization Organization2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistrationAccommodation> AssessmentRegistrationAccommodation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentResult> AssessmentResults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }
    }
}
