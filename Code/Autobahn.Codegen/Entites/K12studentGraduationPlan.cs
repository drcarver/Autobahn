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
    [Table("K12StudentGraduationPlan")]
    public partial class K12studentGraduationPlan
    {
        [Key]
        [Column("K12StudentGraduationPlanId")]
        public int K12studentGraduationPlanId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// Foreign key - K12Course.
        /// </summary>
        [Column("K12CourseId")]
        public int K12courseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? CreditsRequired { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefSCEDCourseSubjectAreaId")]
        public int? RefScedcourseSubjectAreaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefGradeLevelWhenCourseTakenId { get; set; }
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
        [InverseProperty("K12studentGraduationPlans")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12courseId")]
        [InverseProperty("K12studentGraduationPlans")]
        public virtual K12course K12course { get; set; } = null!;
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("K12studentGraduationPlans")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12studentGraduationPlans")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGradeLevelWhenCourseTakenId")]
        [InverseProperty("K12studentGraduationPlans")]
        public virtual RefGradeLevel? RefGradeLevelWhenCourseTaken { get; set; }
        [ForeignKey("RefScedcourseSubjectAreaId")]
        [InverseProperty("K12studentGraduationPlans")]
        public virtual RefScedcourseSubjectArea? RefScedcourseSubjectArea { get; set; }
    }
}
