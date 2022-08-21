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
    [Table("CompetencyDefinition")]
    public partial class CompetencyDefinition
    {
        public CompetencyDefinition()
        {
            AssessmentSubtestCompetencyDefinitions = new HashSet<AssessmentSubtestCompetencyDefinition>();
            CompetencyDefAssociations = new HashSet<CompetencyDefAssociation>();
            CompetencyDefEducationLevels = new HashSet<CompetencyDefEducationLevel>();
            CompetencyDefinitionCompetencySets = new HashSet<CompetencyDefinitionCompetencySet>();
            InverseChildOfCompetencyDefinition = new HashSet<CompetencyDefinition>();
        }

        [Key]
        public int CompetencyDefinitionId { get; set; }
        public int CompetencyFrameworkId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("URL")]
        [StringLength(512)]
        public string? Url { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? Type { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Statement { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Version { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(20)]
        public string? TypicalAgeRange { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? TextComplexitySystem { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? TextComplexityMinimumValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? TextComplexityMaximumValue { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? ConceptTerm { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? ConceptKeyword { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? License { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Notes { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? CompetencyDefParentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? CompetencyDefParentCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? CompetencyDefParentUrl { get; set; }
        [Column("ChildOf_CompetencyDefinitionId")]
        public int? ChildOfCompetencyDefinitionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? CurrentVersionIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? PreviousVersionIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ValidStartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ValidEndDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? ShortName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? CompetencyDefSequence { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("TypeURL")]
        [StringLength(512)]
        public string? TypeUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? TypicalAgeRangeMaximum { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? TypicalAgeRangeMinimum { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLanguageId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefBloomsTaxonomyDomainId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMultipleIntelligenceTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCompetencyDefNodeAccessibilityProfileId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCompetencyDefTestabilityTypeId { get; set; }
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

        [ForeignKey("ChildOfCompetencyDefinitionId")]
        [InverseProperty("InverseChildOfCompetencyDefinition")]
        public virtual CompetencyDefinition? ChildOfCompetencyDefinition { get; set; }
        [ForeignKey("CompetencyFrameworkId")]
        [InverseProperty("CompetencyDefinitions")]
        public virtual CompetencyFramework CompetencyFramework { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CompetencyDefinitions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CompetencyDefinitions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBloomsTaxonomyDomainId")]
        [InverseProperty("CompetencyDefinitions")]
        public virtual RefBloomsTaxonomyDomain? RefBloomsTaxonomyDomain { get; set; }
        [ForeignKey("RefCompetencyDefNodeAccessibilityProfileId")]
        [InverseProperty("CompetencyDefinitions")]
        public virtual RefCompetencyDefNodeAccessibilityProfile? RefCompetencyDefNodeAccessibilityProfile { get; set; }
        [ForeignKey("RefCompetencyDefTestabilityTypeId")]
        [InverseProperty("CompetencyDefinitions")]
        public virtual RefCompetencyDefTestabilityType? RefCompetencyDefTestabilityType { get; set; }
        [ForeignKey("RefLanguageId")]
        [InverseProperty("CompetencyDefinitions")]
        public virtual RefLanguage? RefLanguage { get; set; }
        [ForeignKey("RefMultipleIntelligenceTypeId")]
        [InverseProperty("CompetencyDefinitions")]
        public virtual RefMultipleIntelligenceType? RefMultipleIntelligenceType { get; set; }
        [InverseProperty("CompetencyDefinition")]
        public virtual ICollection<AssessmentSubtestCompetencyDefinition> AssessmentSubtestCompetencyDefinitions { get; set; }
        [InverseProperty("CompetencyDefinition")]
        public virtual ICollection<CompetencyDefAssociation> CompetencyDefAssociations { get; set; }
        [InverseProperty("CompetencyDefinition")]
        public virtual ICollection<CompetencyDefEducationLevel> CompetencyDefEducationLevels { get; set; }
        [InverseProperty("CompetencyDefinition")]
        public virtual ICollection<CompetencyDefinitionCompetencySet> CompetencyDefinitionCompetencySets { get; set; }
        [InverseProperty("ChildOfCompetencyDefinition")]
        public virtual ICollection<CompetencyDefinition> InverseChildOfCompetencyDefinition { get; set; }
    }
}
