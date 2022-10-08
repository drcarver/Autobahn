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
    [Table("CteCourse", Schema = "CTE")]
    public partial class CteCourse
    {
        [Key]
        public int CteCourseId { get; set; }
        public int CourseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? AvailableCarnegieUnitCredit { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? HighSchoolCourseRequirement { get; set; }
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
        [StringLength(5)]
        public string? SCEDCourseCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? CourseDepartmentName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAdditionalCreditTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCreditTypeEarnedId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseGPAApplicabilityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCurriculumFrameworkTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefSCEDCourseLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefSCEDCourseSubjectAreaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCareerClusterId { get; set; }
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
        [InverseProperty("CteCourses")]
        public virtual Course Course { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CteCourses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CteCourses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAdditionalCreditTypeId")]
        [InverseProperty("CteCourses")]
        public virtual RefAdditionalCreditType? RefAdditionalCreditType { get; set; }
        [ForeignKey("RefCareerClusterId")]
        [InverseProperty("CteCourses")]
        public virtual RefCareerCluster? RefCareerCluster { get; set; }
        [ForeignKey("RefCourseGpaapplicabilityId")]
        [InverseProperty("CteCourses")]
        public virtual RefCourseGpaApplicability? RefCourseGpaapplicability { get; set; }
        [ForeignKey("RefCreditTypeEarnedId")]
        [InverseProperty("CteCourses")]
        public virtual RefCreditTypeEarned? RefCreditTypeEarned { get; set; }
        [ForeignKey("RefCurriculumFrameworkTypeId")]
        [InverseProperty("CteCourses")]
        public virtual RefCurriculumFrameworkType? RefCurriculumFrameworkType { get; set; }
        [ForeignKey("RefScedcourseLevelId")]
        [InverseProperty("CteCourses")]
        public virtual RefSCEDCourseLevel? RefScedcourseLevel { get; set; }
        [ForeignKey("RefScedcourseSubjectAreaId")]
        [InverseProperty("CteCourses")]
        public virtual RefScedcourseSubjectArea? RefScedcourseSubjectArea { get; set; }
    }
}
