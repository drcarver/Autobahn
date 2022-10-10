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
    [Table("RefSCEDCourseSubjectArea", Schema = "Education.Common")]
    public partial class RefScedcourseSubjectArea
    {
        public RefScedcourseSubjectArea()
        {
            CteCourses = new HashSet<CteCourse>();
            IndividualizedProgramAccommodationSubjects = new HashSet<IndividualizedProgramAccommodationSubject>();
            K12courses = new HashSet<K12Course>();
            K12studentGraduationPlans = new HashSet<K12StudentGraduationPlan>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("RefSCEDCourseSubjectAreaId")]
        public int RefScedcourseSubjectAreaId { get; set; }
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
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefScedcourseSubjectAreas")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefScedcourseSubjectArea")]
        public virtual ICollection<CteCourse> CteCourses { get; set; }
        [InverseProperty("RefScedcourseSubjectArea")]
        public virtual ICollection<IndividualizedProgramAccommodationSubject> IndividualizedProgramAccommodationSubjects { get; set; }
        [InverseProperty("RefScedcourseSubjectArea")]
        public virtual ICollection<K12Course> K12courses { get; set; }
        [InverseProperty("RefScedcourseSubjectArea")]
        public virtual ICollection<K12StudentGraduationPlan> K12studentGraduationPlans { get; set; }
    }
}
