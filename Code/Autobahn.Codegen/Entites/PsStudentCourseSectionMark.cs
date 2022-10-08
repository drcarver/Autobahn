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
    [Table("PsStudentCourseSectionMark", Schema = "Postsecondary")]
    public partial class PsStudentCourseSectionMark
    {
        [Key]
        public int PsStudentCourseSectionMarkId { get; set; }
        public int PsStudentSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? CourseNarrativeExplanationGrade { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? StudentCourseSectionGradeNarrative { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseAcademicGradeStatusCodeId { get; set; }
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
        [InverseProperty("PsStudentCourseSectionMarks")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PsStudentSectionId")]
        [InverseProperty("PsStudentCourseSectionMarks")]
        public virtual PsStudentSection PsStudentSection { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsStudentCourseSectionMarks")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
