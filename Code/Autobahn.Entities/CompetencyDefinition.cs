using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CompetencyDefinition")]
    public partial class CompetencyDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompetencyDefinition()
        {
            AssessmentSubtestCompetencyDefinition = new HashSet<AssessmentSubtestCompetencyDefinition>();
            CompetencyDefAssociations = new HashSet<CompetencyDefAssociation>();
            CompetencyDefEducationLevels = new HashSet<CompetencyDefEducationLevel>();
            CompetencyDefinition1 = new HashSet<CompetencyDefinition>();
            CompetencyDefinitionCompetencySet = new HashSet<CompetencyDefinitionCompetencySet>();
        }

        public int CompetencyDefinitionId { get; set; }

        public int CompetencyFrameworkId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        [StringLength(30)]
        public string Code { get; set; }

        [StringLength(512)]
        public string URL { get; set; }

        [StringLength(60)]
        public string Type { get; set; }

        public string Statement { get; set; }

        public string Version { get; set; }

        [StringLength(20)]
        public string TypicalAgeRange { get; set; }

        [StringLength(30)]
        public string TextComplexitySystem { get; set; }

        public decimal? TextComplexityMinimumValue { get; set; }

        public decimal? TextComplexityMaximumValue { get; set; }

        [StringLength(30)]
        public string ConceptTerm { get; set; }

        [StringLength(300)]
        public string ConceptKeyword { get; set; }

        [StringLength(300)]
        public string License { get; set; }

        public string Notes { get; set; }

        [StringLength(40)]
        public string CompetencyDefParentId { get; set; }

        [StringLength(30)]
        public string CompetencyDefParentCode { get; set; }

        [StringLength(512)]
        public string CompetencyDefParentUrl { get; set; }

        public int? ChildOfCompetencyDefinitionId { get; set; }

        public bool? CurrentVersionIndicator { get; set; }

        [StringLength(40)]
        public string PreviousVersionIdentifier { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ValidStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ValidEndDate { get; set; }

        [StringLength(30)]
        public string ShortName { get; set; }

        [StringLength(60)]
        public string CompetencyDefSequence { get; set; }

        [StringLength(512)]
        public string TypeURL { get; set; }

        public int? TypicalAgeRangeMaximum { get; set; }

        public int? TypicalAgeRangeMinimum { get; set; }

        public int? RefLanguageId { get; set; }

        public int? RefBloomsTaxonomyDomainId { get; set; }

        public int? RefMultipleIntelligenceTypeId { get; set; }

        public int? RefCompetencyDefNodeAccessibilityProfileId { get; set; }

        public int? RefCompetencyDefTestabilityTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtestCompetencyDefinition> AssessmentSubtestCompetencyDefinition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencyDefAssociation> CompetencyDefAssociations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencyDefEducationLevel> CompetencyDefEducationLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencyDefinition> CompetencyDefinition1 { get; set; }

        public virtual CompetencyDefinition CompetencyDefinition2 { get; set; }

        public virtual CompetencyFramework CompetencyFramework { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencyDefinitionCompetencySet> CompetencyDefinitionCompetencySet { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefBloomsTaxonomyDomain RefBloomsTaxonomyDomain { get; set; }

        public virtual RefCompetencyDefNodeAccessibilityProfile RefCompetencyDefNodeAccessibilityProfile { get; set; }

        public virtual RefCompetencyDefTestabilityType RefCompetencyDefTestabilityType { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        public virtual RefMultipleIntelligenceType RefMultipleIntelligenceType { get; set; }
    }
}
