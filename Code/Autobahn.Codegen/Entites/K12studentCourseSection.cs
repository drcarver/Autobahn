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
    [Table("K12StudentCourseSection")]
    public partial class K12studentCourseSection
    {
        public K12studentCourseSection()
        {
            K12studentCourseSectionMarks = new HashSet<K12studentCourseSectionMark>();
            TeacherStudentDataLinkExclusions = new HashSet<TeacherStudentDataLinkExclusion>();
        }

        [Key]
        [Column("K12StudentCourseSectionId")]
        public int K12studentCourseSectionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(15)]
        public string? GradeEarned { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string? GradeValueQualifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? NumberOfCreditsAttempted { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? NumberOfCreditsEarned { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? TuitionFunded { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ExitWithdrawalDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseRepeatCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseSectionEnrollmentStatusTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseSectionEntryTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseSectionExitTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefExitOrWithdrawalStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefGradeLevelWhenCourseTakenId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCreditTypeEarnedId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdditionalCreditTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPreAndPostTestIndicatorId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProgressLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefCourseGPAApplicabilityId")]
        public int? RefCourseGpaapplicabilityId { get; set; }
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

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAdditionalCreditTypeId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefAdditionalCreditType? RefAdditionalCreditType { get; set; }
        [ForeignKey("RefCourseGpaapplicabilityId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefCourseGpaApplicability? RefCourseGpaapplicability { get; set; }
        [ForeignKey("RefCourseRepeatCodeId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefCourseRepeatCode? RefCourseRepeatCode { get; set; }
        [ForeignKey("RefCourseSectionEnrollmentStatusTypeId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefCourseSectionEnrollmentStatusType? RefCourseSectionEnrollmentStatusType { get; set; }
        [ForeignKey("RefCourseSectionEntryTypeId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefCourseSectionEntryType? RefCourseSectionEntryType { get; set; }
        [ForeignKey("RefCourseSectionExitTypeId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefCourseSectionExitType? RefCourseSectionExitType { get; set; }
        [ForeignKey("RefCreditTypeEarnedId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefCreditTypeEarned? RefCreditTypeEarned { get; set; }
        [ForeignKey("RefExitOrWithdrawalStatusId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefExitOrWithdrawalStatus? RefExitOrWithdrawalStatus { get; set; }
        [ForeignKey("RefGradeLevelWhenCourseTakenId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefGradeLevel? RefGradeLevelWhenCourseTaken { get; set; }
        [ForeignKey("RefPreAndPostTestIndicatorId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefPreAndPostTestIndicator? RefPreAndPostTestIndicator { get; set; }
        [ForeignKey("RefProgressLevelId")]
        [InverseProperty("K12studentCourseSections")]
        public virtual RefProgressLevel? RefProgressLevel { get; set; }
        [InverseProperty("K12studentCourseSection")]
        public virtual ICollection<K12studentCourseSectionMark> K12studentCourseSectionMarks { get; set; }
        [InverseProperty("K12studentCourseSection")]
        public virtual ICollection<TeacherStudentDataLinkExclusion> TeacherStudentDataLinkExclusions { get; set; }
    }
}
