using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("TeacherStudentDataLinkExclusion", Schema = "K12")]
    public partial class TeacherStudentDataLinkExclusion
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int TeacherStudentDataLinkExclusionId { get; set; }
        [Column("K12StudentCourseSectionId")]
        public int K12studentCourseSectionId { get; set; }
        [Column("K12StaffAssignmentId")]
        public int K12staffAssignmentId { get; set; }
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
        [InverseProperty("TeacherStudentDataLinkExclusions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12staffAssignmentId")]
        [InverseProperty("TeacherStudentDataLinkExclusions")]
        public virtual K12StaffAssignment K12staffAssignment { get; set; } = null!;
        [ForeignKey("K12studentCourseSectionId")]
        [InverseProperty("TeacherStudentDataLinkExclusions")]
        public virtual K12StudentCourseSection K12studentCourseSection { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("TeacherStudentDataLinkExclusions")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
