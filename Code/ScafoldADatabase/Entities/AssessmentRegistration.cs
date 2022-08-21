using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("AssessmentRegistration")]
    [Index("PersonId", Name = "IX_AssReg_PersonId")]
    public partial class AssessmentRegistration
    {
        public AssessmentRegistration()
        {
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            AssessmentRegistrationAccommodations = new HashSet<AssessmentRegistrationAccommodation>();
            AssessmentResults = new HashSet<AssessmentResult>();
            LearnerActivities = new HashSet<LearnerActivity>();
        }

        [Key]
        public int AssessmentRegistrationId { get; set; }
        public int PersonId { get; set; }
        public int AssessmentFormId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        public int? DaysOfInstructionPriorToAssessment { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ScorePublishDate { get; set; }
        [StringLength(40)]
        public string? TestAttemptIdentifier { get; set; }
        public bool? RetestIndicator { get; set; }
        public int? CourseSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? TestingIndicator { get; set; }
        public int? OrganizationId { get; set; }
        public int? SchoolOrganizationId { get; set; }
        public int? LeaOrganizationId { get; set; }
        public int? AssessmentAdministrationId { get; set; }
        public int? AssignedByPersonId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AssessmentRegistrationCompletionStatusDateTime { get; set; }
        public bool? StateFullAcademicYear { get; set; }
        [Column("LEAFullAcademicYear")]
        public bool? LeafullAcademicYear { get; set; }
        public bool? SchoolFullAcademicYear { get; set; }
        public int? RefAssessmentParticipationIndicatorId { get; set; }
        public int? RefAssessmentPurposeId { get; set; }
        public int? RefAssessmentReasonNotTestedId { get; set; }
        public int? RefAssessmentReasonNotCompletingId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefGradeLevelToBeAssessedId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefGradeLevelWhenAssessedId { get; set; }
        public int? RefAssessmentRegistrationCompletionStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("AssessmentAdministrationId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual AssessmentAdministration? AssessmentAdministration { get; set; }
        [ForeignKey("AssessmentFormId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual AssessmentForm AssessmentForm { get; set; } = null!;
        [ForeignKey("AssignedByPersonId")]
        [InverseProperty("AssessmentRegistrationAssignedByPeople")]
        public virtual Person? AssignedByPerson { get; set; }
        [ForeignKey("CourseSectionId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual CourseSection? CourseSection { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LeaOrganizationId")]
        [InverseProperty("AssessmentRegistrationLeaOrganizations")]
        public virtual Organization? LeaOrganization { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("AssessmentRegistrationOrganizations")]
        public virtual Organization? Organization { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("AssessmentRegistrationPeople")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentParticipationIndicatorId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual RefAssessmentParticipationIndicator? RefAssessmentParticipationIndicator { get; set; }
        [ForeignKey("RefAssessmentPurposeId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual RefAssessmentPurpose? RefAssessmentPurpose { get; set; }
        [ForeignKey("RefAssessmentReasonNotCompletingId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual RefAssessmentReasonNotCompleting? RefAssessmentReasonNotCompleting { get; set; }
        [ForeignKey("RefAssessmentReasonNotTestedId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual RefAssessmentReasonNotTested? RefAssessmentReasonNotTested { get; set; }
        [ForeignKey("RefAssessmentRegistrationCompletionStatusId")]
        [InverseProperty("AssessmentRegistrations")]
        public virtual RefAssessmentRegistrationCompletionStatus? RefAssessmentRegistrationCompletionStatus { get; set; }
        [ForeignKey("RefGradeLevelToBeAssessedId")]
        [InverseProperty("AssessmentRegistrationRefGradeLevelToBeAssesseds")]
        public virtual RefGradeLevel? RefGradeLevelToBeAssessed { get; set; }
        [ForeignKey("RefGradeLevelWhenAssessedId")]
        [InverseProperty("AssessmentRegistrationRefGradeLevelWhenAssesseds")]
        public virtual RefGradeLevel? RefGradeLevelWhenAssessed { get; set; }
        [ForeignKey("SchoolOrganizationId")]
        [InverseProperty("AssessmentRegistrationSchoolOrganizations")]
        public virtual Organization? SchoolOrganization { get; set; }
        [InverseProperty("AssessmentRegistration")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }
        [InverseProperty("AssessmentRegistration")]
        public virtual ICollection<AssessmentRegistrationAccommodation> AssessmentRegistrationAccommodations { get; set; }
        [InverseProperty("AssessmentRegistration")]
        public virtual ICollection<AssessmentResult> AssessmentResults { get; set; }
        [InverseProperty("AssessmentRegistration")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }
    }
}
