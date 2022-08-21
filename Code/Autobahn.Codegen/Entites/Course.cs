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
    [Table("Course")]
    public partial class Course
    {
        public Course()
        {
            CourseSections = new HashSet<CourseSection>();
            CredentialCriteriaCourses = new HashSet<CredentialCriteriaCourse>();
            CteCourses = new HashSet<CteCourse>();
            K12courses = new HashSet<K12course>();
            ProfessionalDevelopmentActivities = new HashSet<ProfessionalDevelopmentActivity>();
            PsCourses = new HashSet<PsCourse>();
        }

        [Key]
        public int CourseId { get; set; }
        /// <summary>
        /// Surrogate key from Organization.
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(50)]
        public string? SubjectAbbreviation { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("SCEDSequenceOfCourse")]
        [StringLength(50)]
        public string? ScedsequenceOfCourse { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? InstructionalMinutes { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? CreditValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? CertificationDescription { get; set; }
        public int? RepeatabilityMaximumNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseLevelCharacteristicsId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseCreditUnitId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInstructionLanguageId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseApplicableEducationLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("Courses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("Courses")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Courses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCourseApplicableEducationLevelId")]
        [InverseProperty("Courses")]
        public virtual RefCourseApplicableEducationLevel? RefCourseApplicableEducationLevel { get; set; }
        [ForeignKey("RefCourseCreditUnitId")]
        [InverseProperty("Courses")]
        public virtual RefCourseCreditUnit? RefCourseCreditUnit { get; set; }
        [ForeignKey("RefCourseLevelCharacteristicsId")]
        [InverseProperty("Courses")]
        public virtual RefCourseLevelCharacteristic? RefCourseLevelCharacteristics { get; set; }
        [ForeignKey("RefInstructionLanguageId")]
        [InverseProperty("Courses")]
        public virtual RefLanguage? RefInstructionLanguage { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<CourseSection> CourseSections { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<CredentialCriteriaCourse> CredentialCriteriaCourses { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<CteCourse> CteCourses { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<K12course> K12courses { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<ProfessionalDevelopmentActivity> ProfessionalDevelopmentActivities { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<PsCourse> PsCourses { get; set; }
    }
}
