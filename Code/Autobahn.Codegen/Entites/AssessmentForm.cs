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
    [Table("AssessmentForm")]
    public partial class AssessmentForm
    {
        public AssessmentForm()
        {
            AssessmentFormAssessmentAssets = new HashSet<AssessmentFormAssessmentAsset>();
            AssessmentFormAssessmentFormSections = new HashSet<AssessmentFormAssessmentFormSection>();
            AssessmentRegistrations = new HashSet<AssessmentRegistration>();
            AssessmentSubtests = new HashSet<AssessmentSubtest>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentFormId { get; set; }
        /// <summary>
        /// Foreign key - Assessment
        /// </summary>
        public int AssessmentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? FormNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Name { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Version { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? AccommodationList { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? IntendedAdministrationStartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? IntendedAdministrationEndDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? AssessmentItemBankIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? AssessmentItemBankName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? PlatformsSupported { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentLanguageId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AssessmentSecureIndicator { get; set; }
        /// <summary>
        /// Foreign key - LearningResouce
        /// </summary>
        public int? LearningResourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AssessmentFormAdaptiveIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? AssessmentFormAlgorithmIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? AssessmentFormAlgorithmVersion { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("AssessmentFormGUID")]
        [StringLength(40)]
        public string? AssessmentFormGuid { get; set; }
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

        [ForeignKey("AssessmentId")]
        [InverseProperty("AssessmentForms")]
        public virtual Assessment Assessment { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentForms")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LearningResourceId")]
        [InverseProperty("AssessmentForms")]
        public virtual LearningResource? LearningResource { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentForms")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentLanguageId")]
        [InverseProperty("AssessmentForms")]
        public virtual RefLanguage? RefAssessmentLanguage { get; set; }
        [InverseProperty("AssessmentForm")]
        public virtual ICollection<AssessmentFormAssessmentAsset> AssessmentFormAssessmentAssets { get; set; }
        [InverseProperty("AssessmentForm")]
        public virtual ICollection<AssessmentFormAssessmentFormSection> AssessmentFormAssessmentFormSections { get; set; }
        [InverseProperty("AssessmentForm")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }
        [InverseProperty("AssessmentForm")]
        public virtual ICollection<AssessmentSubtest> AssessmentSubtests { get; set; }
    }
}
