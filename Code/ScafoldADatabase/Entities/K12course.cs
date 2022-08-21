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
    [Table("K12Course")]
    public partial class K12course
    {
        public K12course()
        {
            K12studentGraduationPlans = new HashSet<K12studentGraduationPlan>();
        }

        [Key]
        [Column("K12CourseId")]
        public int K12courseId { get; set; }
        public int CourseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? HighSchoolCourseRequirement { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? AvailableCarnegieUnitCredit { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? CoreAcademicCourse { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? CourseAlignedWithStandards { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? FundingProgram { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? FamilyConsumerSciencesCourseInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("SCEDCourseCode")]
        [StringLength(5)]
        public string? ScedcourseCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("SCEDGradeSpan")]
        [StringLength(4)]
        public string? ScedgradeSpan { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? CourseDepartmentName { get; set; }
        /// <summary>
        /// Foreign key - RefCreditTypeEarned
        /// </summary>
        public int? RefCreditTypeEarnedId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdditionalCreditTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefCourseGPAApplicabilityId")]
        public int? RefCourseGpaapplicabilityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCurriculumFrameworkTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefSCEDCourseLevelId")]
        public int? RefScedcourseLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefSCEDCourseSubjectAreaId")]
        public int? RefScedcourseSubjectAreaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCareerClusterId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefBlendedLearningModelTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseInteractionModeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefK12EndOfCourseRequirementId")]
        public int? RefK12endOfCourseRequirementId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("CourseId")]
        [InverseProperty("K12courses")]
        public virtual Course Course { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12courses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12courses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAdditionalCreditTypeId")]
        [InverseProperty("K12courses")]
        public virtual RefAdditionalCreditType? RefAdditionalCreditType { get; set; }
        [ForeignKey("RefBlendedLearningModelTypeId")]
        [InverseProperty("K12courses")]
        public virtual RefBlendedLearningModelType? RefBlendedLearningModelType { get; set; }
        [ForeignKey("RefCareerClusterId")]
        [InverseProperty("K12courses")]
        public virtual RefCareerCluster? RefCareerCluster { get; set; }
        [ForeignKey("RefCourseGpaapplicabilityId")]
        [InverseProperty("K12courses")]
        public virtual RefCourseGpaApplicability? RefCourseGpaapplicability { get; set; }
        [ForeignKey("RefCourseInteractionModeId")]
        [InverseProperty("K12courses")]
        public virtual RefCourseInteractionMode? RefCourseInteractionMode { get; set; }
        [ForeignKey("RefCreditTypeEarnedId")]
        [InverseProperty("K12courses")]
        public virtual RefCreditTypeEarned? RefCreditTypeEarned { get; set; }
        [ForeignKey("RefCurriculumFrameworkTypeId")]
        [InverseProperty("K12courses")]
        public virtual RefCurriculumFrameworkType? RefCurriculumFrameworkType { get; set; }
        [ForeignKey("RefK12endOfCourseRequirementId")]
        [InverseProperty("K12courses")]
        public virtual RefK12endOfCourseRequirement? RefK12endOfCourseRequirement { get; set; }
        [ForeignKey("RefScedcourseLevelId")]
        [InverseProperty("K12courses")]
        public virtual RefScedcourseLevel? RefScedcourseLevel { get; set; }
        [ForeignKey("RefScedcourseSubjectAreaId")]
        [InverseProperty("K12courses")]
        public virtual RefScedcourseSubjectArea? RefScedcourseSubjectArea { get; set; }
        [ForeignKey("RefWorkbasedLearningOpportunityTypeId")]
        [InverseProperty("K12courses")]
        public virtual RefWorkbasedLearningOpportunityType? RefWorkbasedLearningOpportunityType { get; set; }
        [InverseProperty("K12course")]
        public virtual ICollection<K12studentGraduationPlan> K12studentGraduationPlans { get; set; }
    }
}
