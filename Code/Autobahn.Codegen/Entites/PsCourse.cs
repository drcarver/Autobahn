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
    [Table("PsCourse", Schema = "Postsecondary")]
    public partial class PsCourse
    {
        [Key]
        public int PsCourseId { get; set; }
        public int CourseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? CourseNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? OriginalCourseIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? OverrideSchoolCourseNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? NCAAEligibilityInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseCreditBasisTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseCreditLevelTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefNCESCollegeCourseMapCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCipCodeId { get; set; }
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
        [InverseProperty("PsCourses")]
        public virtual Course Course { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("PsCourses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsCourses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCipCodeId")]
        [InverseProperty("PsCourses")]
        public virtual RefCipCode? RefCipCode { get; set; }
        [ForeignKey("RefCourseCreditBasisTypeId")]
        [InverseProperty("PsCourses")]
        public virtual RefCourseCreditBasisType? RefCourseCreditBasisType { get; set; }
        [ForeignKey("RefCourseCreditLevelTypeId")]
        [InverseProperty("PsCourses")]
        public virtual RefCourseCreditLevelType? RefCourseCreditLevelType { get; set; }
        [ForeignKey("RefNcescollegeCourseMapCodeId")]
        [InverseProperty("PsCourses")]
        public virtual RefNCESCollegeCourseMapCode? RefNcescollegeCourseMapCode { get; set; }
    }
}
