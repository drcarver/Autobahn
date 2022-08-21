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
    [Table("LearningResource")]
    public partial class LearningResource
    {
        public LearningResource()
        {
            AssessmentAssets = new HashSet<AssessmentAsset>();
            AssessmentFormSections = new HashSet<AssessmentFormSection>();
            AssessmentForms = new HashSet<AssessmentForm>();
            AssessmentItems = new HashSet<AssessmentItem>();
            LearnerActivityLearningResources = new HashSet<LearnerActivityLearningResource>();
            LearningResourceAdaptations = new HashSet<LearningResourceAdaptation>();
            LearningResourceEducationLevels = new HashSet<LearningResourceEducationLevel>();
            LearningResourceMediaFeatures = new HashSet<LearningResourceMediaFeature>();
            LearningResourcePeerRatings = new HashSet<LearningResourcePeerRating>();
            LearningResourcePhysicalMedia = new HashSet<LearningResourcePhysicalMedium>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int LearningResourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Title { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? Url { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? ConceptKeyword { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? SubjectName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? SubjectCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? SubjectCodeSystem { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Version { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Creator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? PublisherName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? CopyrightHolderName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(4)]
        public string? CopyrightYear { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("LearningResourceLicenseURL")]
        [StringLength(512)]
        public string? LearningResourceLicenseUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? BasedOnUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceIntendedEndUserRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceEducationalUseId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceInteractivityTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLanguageId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? TimeRequired { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public byte? TypicalAgeRangeMinimum { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public byte? TypicalAgeRangeMaximum { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? TextComplexityValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? TextComplexitySystem { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("AdaptedFromURL")]
        [StringLength(512)]
        public string? AdaptedFromUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? AssistiveTechnologiesCompatibleInd { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? PeerRatingSampleSize { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefLearningResourceAccessAPITypeId")]
        public int? RefLearningResourceAccessApitypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceAccessHazardTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceAccessModeTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceBookFormatTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceControlFlexibilityTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceDigitalMediaSubTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceDigitalMediaTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(128)]
        public string? LearningResourceAuthorEmail { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("LearningResourceAuthorURL")]
        [StringLength(512)]
        public string? LearningResourceAuthorUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? LearningResourceDateModified { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(128)]
        public string? LearningResourcePublisherEmail { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("LearningResourcePublisherURL")]
        [StringLength(512)]
        public string? LearningResourcePublisherUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceAccessRightsUrlId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceAuthorTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLearningResourceInteractionModeId { get; set; }
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
        [InverseProperty("LearningResources")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("LearningResources")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefLanguageId")]
        [InverseProperty("LearningResources")]
        public virtual RefLanguage? RefLanguage { get; set; }
        [ForeignKey("RefLearningResourceAccessApitypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceAccessApitype? RefLearningResourceAccessApitype { get; set; }
        [ForeignKey("RefLearningResourceAccessHazardTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceAccessHazardType? RefLearningResourceAccessHazardType { get; set; }
        [ForeignKey("RefLearningResourceAccessModeTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceAccessModeType? RefLearningResourceAccessModeType { get; set; }
        [ForeignKey("RefLearningResourceAccessRightsUrlId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceAccessRightsUrl? RefLearningResourceAccessRightsUrl { get; set; }
        [ForeignKey("RefLearningResourceAuthorTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceAuthorType? RefLearningResourceAuthorType { get; set; }
        [ForeignKey("RefLearningResourceBookFormatTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceBookFormatType? RefLearningResourceBookFormatType { get; set; }
        [ForeignKey("RefLearningResourceControlFlexibilityTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceControlFlexibilityType? RefLearningResourceControlFlexibilityType { get; set; }
        [ForeignKey("RefLearningResourceDigitalMediaSubTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceDigitalMediaSubType? RefLearningResourceDigitalMediaSubType { get; set; }
        [ForeignKey("RefLearningResourceDigitalMediaTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceDigitalMediaType? RefLearningResourceDigitalMediaType { get; set; }
        [ForeignKey("RefLearningResourceEducationalUseId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceEducationalUse? RefLearningResourceEducationalUse { get; set; }
        [ForeignKey("RefLearningResourceIntendedEndUserRoleId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceIntendedEndUserRole? RefLearningResourceIntendedEndUserRole { get; set; }
        [ForeignKey("RefLearningResourceInteractionModeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceInteractionMode? RefLearningResourceInteractionMode { get; set; }
        [ForeignKey("RefLearningResourceInteractivityTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceInteractivityType? RefLearningResourceInteractivityType { get; set; }
        [ForeignKey("RefLearningResourceTypeId")]
        [InverseProperty("LearningResources")]
        public virtual RefLearningResourceType? RefLearningResourceType { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<AssessmentAsset> AssessmentAssets { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<AssessmentFormSection> AssessmentFormSections { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<AssessmentForm> AssessmentForms { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<AssessmentItem> AssessmentItems { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<LearnerActivityLearningResource> LearnerActivityLearningResources { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<LearningResourceAdaptation> LearningResourceAdaptations { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<LearningResourceEducationLevel> LearningResourceEducationLevels { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<LearningResourceMediaFeature> LearningResourceMediaFeatures { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<LearningResourcePeerRating> LearningResourcePeerRatings { get; set; }
        [InverseProperty("LearningResource")]
        public virtual ICollection<LearningResourcePhysicalMedium> LearningResourcePhysicalMedia { get; set; }
    }
}
