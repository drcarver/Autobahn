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
    [Table("PsSection")]
    public partial class PsSection
    {
        public PsSection()
        {
            PsSectionLocations = new HashSet<PsSectionLocation>();
        }

        [Key]
        public int PsSectionId { get; set; }
        public int CourseSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(2)]
        public string? GradeValueQualifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCipCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefCourseGPAApplicabilityId")]
        public int? RefCourseGpaapplicabilityId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseHonorsTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseInstructionMethodId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseLevelTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefDevelopmentalEducationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }
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

        [ForeignKey("CourseSectionId")]
        [InverseProperty("PsSections")]
        public virtual CourseSection CourseSection { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("PsSections")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsSections")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCipCodeId")]
        [InverseProperty("PsSections")]
        public virtual RefCipCode? RefCipCode { get; set; }
        [ForeignKey("RefCourseGpaapplicabilityId")]
        [InverseProperty("PsSections")]
        public virtual RefCourseGpaApplicability? RefCourseGpaapplicability { get; set; }
        [ForeignKey("RefCourseHonorsTypeId")]
        [InverseProperty("PsSections")]
        public virtual RefCourseHonorsType? RefCourseHonorsType { get; set; }
        [ForeignKey("RefCourseInstructionMethodId")]
        [InverseProperty("PsSections")]
        public virtual RefCourseInstructionMethod? RefCourseInstructionMethod { get; set; }
        [ForeignKey("RefCourseLevelTypeId")]
        [InverseProperty("PsSections")]
        public virtual RefCourseLevelType? RefCourseLevelType { get; set; }
        [ForeignKey("RefDevelopmentalEducationTypeId")]
        [InverseProperty("PsSections")]
        public virtual RefDevelopmentalEducationType? RefDevelopmentalEducationType { get; set; }
        [ForeignKey("RefWorkbasedLearningOpportunityTypeId")]
        [InverseProperty("PsSections")]
        public virtual RefWorkbasedLearningOpportunityType? RefWorkbasedLearningOpportunityType { get; set; }
        [InverseProperty("PsSection")]
        public virtual ICollection<PsSectionLocation> PsSectionLocations { get; set; }
    }
}
