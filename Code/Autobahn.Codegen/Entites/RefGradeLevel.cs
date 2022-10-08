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
    [Table("RefGradeLevel", Schema = "Common")]
    public partial class RefGradeLevel
    {
        public RefGradeLevel()
        {
            AssessmentLevelsForWhichDesigneds = new HashSet<AssessmentLevelsForWhichDesigned>();
            AssessmentRegistrationRefGradeLevelToBeAssesseds = new HashSet<AssessmentRegistration>();
            AssessmentRegistrationRefGradeLevelWhenAssesseds = new HashSet<AssessmentRegistration>();
            AssessmentSubtestLevelsForWhichDesigneds = new HashSet<AssessmentSubtestLevelsForWhichDesigned>();
            K12leaGradeLevelsApproveds = new HashSet<K12LeaGradeLevelsApproved>();
            K12leaGradeOffereds = new HashSet<K12LeaGradeOffered>();
            K12schoolGradeLevelsApproveds = new HashSet<K12SchoolGradeLevelsApproved>();
            K12schoolGradeOffereds = new HashSet<K12SchoolGradeOffered>();
            K12studentCourseSections = new HashSet<K12StudentCourseSection>();
            K12studentEnrollmentRefEntryGradeLevels = new HashSet<K12StudentEnrollment>();
            K12studentEnrollmentRefExitGradeLevels = new HashSet<K12StudentEnrollment>();
            K12studentGraduationPlans = new HashSet<K12StudentGraduationPlan>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefGradeLevelId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        public int? RefGradeLevelTypeId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefGradeLevelTypeId")]
        [InverseProperty("RefGradeLevels")]
        public virtual RefGradeLevelType? RefGradeLevelType { get; set; }
        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefGradeLevels")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefGradeLevel")]
        public virtual ICollection<AssessmentLevelsForWhichDesigned> AssessmentLevelsForWhichDesigneds { get; set; }
        [InverseProperty("RefGradeLevelToBeAssessed")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrationRefGradeLevelToBeAssesseds { get; set; }
        [InverseProperty("RefGradeLevelWhenAssessed")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrationRefGradeLevelWhenAssesseds { get; set; }
        [InverseProperty("RefGrade")]
        public virtual ICollection<AssessmentSubtestLevelsForWhichDesigned> AssessmentSubtestLevelsForWhichDesigneds { get; set; }
        [InverseProperty("RefGradeLevel")]
        public virtual ICollection<K12LeaGradeLevelsApproved> K12leaGradeLevelsApproveds { get; set; }
        [InverseProperty("RefGradeLevel")]
        public virtual ICollection<K12LeaGradeOffered> K12leaGradeOffereds { get; set; }
        [InverseProperty("RefGradeLevel")]
        public virtual ICollection<K12SchoolGradeLevelsApproved> K12schoolGradeLevelsApproveds { get; set; }
        [InverseProperty("RefGradeLevel")]
        public virtual ICollection<K12SchoolGradeOffered> K12schoolGradeOffereds { get; set; }
        [InverseProperty("RefGradeLevelWhenCourseTaken")]
        public virtual ICollection<K12StudentCourseSection> K12studentCourseSections { get; set; }
        [InverseProperty("RefEntryGradeLevel")]
        public virtual ICollection<K12StudentEnrollment> K12studentEnrollmentRefEntryGradeLevels { get; set; }
        [InverseProperty("RefExitGradeLevel")]
        public virtual ICollection<K12StudentEnrollment> K12studentEnrollmentRefExitGradeLevels { get; set; }
        [InverseProperty("RefGradeLevelWhenCourseTaken")]
        public virtual ICollection<K12StudentGraduationPlan> K12studentGraduationPlans { get; set; }
    }
}
