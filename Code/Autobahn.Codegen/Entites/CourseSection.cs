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
    [Table("CourseSection", Schema = "Common")]
    public partial class CourseSection
    {
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

        [Key]
        public int CourseSectionId { get; set; }
        /// <summary>
        /// Surrogate key from Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// Foreign key - Course.
        /// </summary>
        public int CourseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? AvailableCarnegieUnitCredit { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 0)")]
        public decimal? TimeRequiredForCompletion { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? VirtualIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? OrganizationCalendarSessionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? MaximumCapacity { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? RelatedCompetencyDefinitions { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseSectionDeliveryModeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefSingleSexClassStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdditionalCreditTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInstructionLanguageId { get; set; }
        /// <summary>
        /// Foreign key - RefCreditTypeEarned
        /// </summary>
        public int? RefCreditTypeEarnedId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdvancedPlacementCourseCodeId { get; set; }
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

        [ForeignKey("CourseId")]
        [InverseProperty("CourseSections")]
        public virtual Course Course { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CourseSections")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("CourseSections")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("OrganizationCalendarSessionId")]
        [InverseProperty("CourseSections")]
        public virtual OrganizationCalendarSession? OrganizationCalendarSession { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CourseSections")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAdvancedPlacementCourseCodeId")]
        [InverseProperty("CourseSections")]
        public virtual RefAdvancedPlacementCourseCode? RefAdvancedPlacementCourseCode { get; set; }
        [ForeignKey("RefCourseSectionDeliveryModeId")]
        [InverseProperty("CourseSections")]
        public virtual RefCourseSectionDeliveryMode? RefCourseSectionDeliveryMode { get; set; }
        [ForeignKey("RefCreditTypeEarnedId")]
        [InverseProperty("CourseSections")]
        public virtual RefCreditTypeEarned? RefCreditTypeEarned { get; set; }
        [ForeignKey("RefInstructionLanguageId")]
        [InverseProperty("CourseSections")]
        public virtual RefLanguage? RefInstructionLanguage { get; set; }
        [ForeignKey("RefSingleSexClassStatusId")]
        [InverseProperty("CourseSections")]
        public virtual RefSingleSexClassStatus? RefSingleSexClassStatus { get; set; }
        [InverseProperty("CourseSection")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }
        [InverseProperty("CourseSection")]
        public virtual ICollection<CourseSectionAssessmentReporting> CourseSectionAssessmentReportings { get; set; }
        [InverseProperty("CourseSection")]
        public virtual ICollection<CourseSectionLevel> CourseSectionLevels { get; set; }
        [InverseProperty("CourseSection")]
        public virtual ICollection<CourseSectionLocation> CourseSectionLocations { get; set; }
        [InverseProperty("CourseSection")]
        public virtual ICollection<CourseSectionSchedule> CourseSectionSchedules { get; set; }
        [InverseProperty("CourseSection")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }
        [InverseProperty("CourseSection")]
        public virtual ICollection<PsSection> PsSections { get; set; }
    }
}
