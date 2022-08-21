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
    [Table("Assessment")]
    public partial class Assessment
    {
        public Assessment()
        {
            AssessmentAssessmentAdministrations = new HashSet<AssessmentAssessmentAdministration>();
            AssessmentEldevelopmentalDomains = new HashSet<AssessmentEldevelopmentalDomain>();
            AssessmentForms = new HashSet<AssessmentForm>();
            AssessmentLanguages = new HashSet<AssessmentLanguage>();
            AssessmentLevelsForWhichDesigneds = new HashSet<AssessmentLevelsForWhichDesigned>();
            IndividualizedProgramAssessments = new HashSet<IndividualizedProgramAssessment>();
        }

        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int AssessmentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? IdentificationSystem { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("GUID")]
        [StringLength(40)]
        public string? Guid { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Title { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? ShortName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefAcademicSubjectId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(100)]
        public string? Objective { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Provider { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentPurposeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? AssessmentRevisionDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string AssessmentFamilyTitle { get; set; } = null!;
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? AssessmentFamilyShortName { get; set; }
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
        [InverseProperty("Assessments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Assessments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAcademicSubjectId")]
        [InverseProperty("Assessments")]
        public virtual RefAcademicSubject RefAcademicSubject { get; set; } = null!;
        [ForeignKey("RefAssessmentPurposeId")]
        [InverseProperty("Assessments")]
        public virtual RefAssessmentPurpose? RefAssessmentPurpose { get; set; }
        [ForeignKey("RefAssessmentTypeId")]
        [InverseProperty("Assessments")]
        public virtual RefAssessmentType? RefAssessmentType { get; set; }
        [ForeignKey("RefAssessmentTypeChildrenWithDisabilitiesId")]
        [InverseProperty("Assessments")]
        public virtual RefAssessmentTypeChildrenWithDisability? RefAssessmentTypeChildrenWithDisabilities { get; set; }
        [InverseProperty("Assessment")]
        public virtual ICollection<AssessmentAssessmentAdministration> AssessmentAssessmentAdministrations { get; set; }
        [InverseProperty("Assessment")]
        public virtual ICollection<AssessmentEldevelopmentalDomain> AssessmentEldevelopmentalDomains { get; set; }
        [InverseProperty("Assessment")]
        public virtual ICollection<AssessmentForm> AssessmentForms { get; set; }
        [InverseProperty("Assessment")]
        public virtual ICollection<AssessmentLanguage> AssessmentLanguages { get; set; }
        [InverseProperty("Assessment")]
        public virtual ICollection<AssessmentLevelsForWhichDesigned> AssessmentLevelsForWhichDesigneds { get; set; }
        [InverseProperty("Assessment")]
        public virtual ICollection<IndividualizedProgramAssessment> IndividualizedProgramAssessments { get; set; }
    }
}
