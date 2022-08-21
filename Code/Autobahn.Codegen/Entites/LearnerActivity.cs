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
    [Table("LearnerActivity")]
    public partial class LearnerActivity
    {
        public LearnerActivity()
        {
            LearnerActivityLearningResources = new HashSet<LearnerActivityLearningResource>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int LearnerActivityId { get; set; }
        /// <summary>
        /// Foreign key - Person.
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Foreign key - AssessmentRegistration.
        /// </summary>
        public int? AssessmentRegistrationId { get; set; }
        /// <summary>
        /// Surrogate key from CourseSection.
        /// </summary>
        public int? CourseSectionId { get; set; }
        /// <summary>
        /// Foreign key - Session
        /// </summary>
        public int? OrganizationCalendarSessionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Title { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? Prerequisite { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearnerActivityTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? RubricUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CreationDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 0)")]
        public decimal? MaximumTimeAllowed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? DueTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 0)")]
        public decimal? MaximumAttemptsAllowed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearnerActivityAddToGradeBookFlagId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? Weight { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? PossiblePoints { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLanguageId { get; set; }
        /// <summary>
        /// Foreign key - Person
        /// </summary>
        public int? AssignedByPersonId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int? SchoolOrganizationId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int? LeaOrganizationId { get; set; }
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

        [ForeignKey("AssessmentRegistrationId")]
        [InverseProperty("LearnerActivities")]
        public virtual AssessmentRegistration? AssessmentRegistration { get; set; }
        [ForeignKey("AssignedByPersonId")]
        [InverseProperty("LearnerActivityAssignedByPeople")]
        public virtual Person? AssignedByPerson { get; set; }
        [ForeignKey("CourseSectionId")]
        [InverseProperty("LearnerActivities")]
        public virtual CourseSection? CourseSection { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("LearnerActivities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LeaOrganizationId")]
        [InverseProperty("LearnerActivityLeaOrganizations")]
        public virtual Organization? LeaOrganization { get; set; }
        [ForeignKey("OrganizationCalendarSessionId")]
        [InverseProperty("LearnerActivities")]
        public virtual OrganizationCalendarSession? OrganizationCalendarSession { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("LearnerActivityPeople")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("LearnerActivities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefLearnerActivityMaximumTimeAllowedUnitsId")]
        [InverseProperty("LearnerActivities")]
        public virtual RefLearnerActivityMaximumTimeAllowedUnit? RefLearnerActivityMaximumTimeAllowedUnits { get; set; }
        [ForeignKey("RefLearnerActivityTypeId")]
        [InverseProperty("LearnerActivities")]
        public virtual RefLearnerActivityType? RefLearnerActivityType { get; set; }
        [ForeignKey("SchoolOrganizationId")]
        [InverseProperty("LearnerActivitySchoolOrganizations")]
        public virtual Organization? SchoolOrganization { get; set; }
        [InverseProperty("LearnerActivity")]
        public virtual ICollection<LearnerActivityLearningResource> LearnerActivityLearningResources { get; set; }
    }
}
