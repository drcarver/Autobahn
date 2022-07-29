using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LearningResource")]
    public partial class LearningResource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LearningResource()
        {
            AssessmentAssets = new HashSet<AssessmentAsset>();
            AssessmentForms = new HashSet<AssessmentForm>();
            AssessmentFormSections = new HashSet<AssessmentFormSection>();
            AssessmentItems = new HashSet<AssessmentItem>();
            LearnerActivity_LearningResource = new HashSet<LearnerActivity_LearningResource>();
            LearningResourceEducationLevels = new HashSet<LearningResourceEducationLevel>();
            LearningResourceAdaptations = new HashSet<LearningResourceAdaptation>();
            LearningResourceMediaFeatures = new HashSet<LearningResourceMediaFeature>();
            LearningResourcePeerRatings = new HashSet<LearningResourcePeerRating>();
            LearningResourcePhysicalMedias = new HashSet<LearningResourcePhysicalMedia>();
        }

        public int LearningResourceId { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(512)]
        public string Url { get; set; }

        [StringLength(300)]
        public string ConceptKeyword { get; set; }

        [StringLength(30)]
        public string SubjectName { get; set; }

        [StringLength(30)]
        public string SubjectCode { get; set; }

        [StringLength(30)]
        public string SubjectCodeSystem { get; set; }

        public int? RefLearningResourceTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        [StringLength(30)]
        public string Version { get; set; }

        [StringLength(60)]
        public string Creator { get; set; }

        [StringLength(60)]
        public string PublisherName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }

        [StringLength(60)]
        public string CopyrightHolderName { get; set; }

        [StringLength(4)]
        public string CopyrightYear { get; set; }

        [StringLength(512)]
        public string LearningResourceLicenseURL { get; set; }

        [StringLength(512)]
        public string BasedOnUrl { get; set; }

        public int? RefLearningResourceIntendedEndUserRoleId { get; set; }

        public int? RefLearningResourceEducationalUseId { get; set; }

        public int? RefLearningResourceInteractivityTypeId { get; set; }

        public int? RefLanguageId { get; set; }

        public decimal? TimeRequired { get; set; }

        public byte? TypicalAgeRangeMinimum { get; set; }

        public byte? TypicalAgeRangeMaximum { get; set; }

        [StringLength(30)]
        public string TextComplexityValue { get; set; }

        [StringLength(30)]
        public string TextComplexitySystem { get; set; }

        [StringLength(512)]
        public string AdaptedFromURL { get; set; }

        public bool? AssistiveTechnologiesCompatibleInd { get; set; }

        public int? PeerRatingSampleSize { get; set; }

        public int? RefLearningResourceAccessAPITypeId { get; set; }

        public int? RefLearningResourceAccessHazardTypeId { get; set; }

        public int? RefLearningResourceAccessModeTypeId { get; set; }

        public int? RefLearningResourceBookFormatTypeId { get; set; }

        public int? RefLearningResourceControlFlexibilityTypeId { get; set; }

        public int? RefLearningResourceDigitalMediaSubTypeId { get; set; }

        public int? RefLearningResourceDigitalMediaTypeId { get; set; }

        [StringLength(128)]
        public string LearningResourceAuthorEmail { get; set; }

        [StringLength(512)]
        public string LearningResourceAuthorURL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LearningResourceDateModified { get; set; }

        [StringLength(128)]
        public string LearningResourcePublisherEmail { get; set; }

        [StringLength(512)]
        public string LearningResourcePublisherURL { get; set; }

        public int? RefLearningResourceAccessRightsUrlId { get; set; }

        public int? RefLearningResourceAuthorTypeId { get; set; }

        public int? RefLearningResourceInteractionModeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentAsset> AssessmentAssets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentForm> AssessmentForms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentFormSection> AssessmentFormSections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentItem> AssessmentItems { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity_LearningResource> LearnerActivity_LearningResource { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningResourceEducationLevel> LearningResourceEducationLevels { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        public virtual RefLearningResourceAccessAPIType RefLearningResourceAccessAPIType { get; set; }

        public virtual RefLearningResourceAccessHazardType RefLearningResourceAccessHazardType { get; set; }

        public virtual RefLearningResourceAccessModeType RefLearningResourceAccessModeType { get; set; }

        public virtual RefLearningResourceAccessRightsUrl RefLearningResourceAccessRightsUrl { get; set; }

        public virtual RefLearningResourceAuthorType RefLearningResourceAuthorType { get; set; }

        public virtual RefLearningResourceBookFormatType RefLearningResourceBookFormatType { get; set; }

        public virtual RefLearningResourceControlFlexibilityType RefLearningResourceControlFlexibilityType { get; set; }

        public virtual RefLearningResourceDigitalMediaSubType RefLearningResourceDigitalMediaSubType { get; set; }

        public virtual RefLearningResourceDigitalMediaType RefLearningResourceDigitalMediaType { get; set; }

        public virtual RefLearningResourceInteractionMode RefLearningResourceInteractionMode { get; set; }

        public virtual RefLearningResourceEducationalUse RefLearningResourceEducationalUse { get; set; }

        public virtual RefLearningResourceIntendedEndUserRole RefLearningResourceIntendedEndUserRole { get; set; }

        public virtual RefLearningResourceInteractivityType RefLearningResourceInteractivityType { get; set; }

        public virtual RefLearningResourceType RefLearningResourceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningResourceAdaptation> LearningResourceAdaptations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningResourceMediaFeature> LearningResourceMediaFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningResourcePeerRating> LearningResourcePeerRatings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningResourcePhysicalMedia> LearningResourcePhysicalMedias { get; set; }
    }
}
