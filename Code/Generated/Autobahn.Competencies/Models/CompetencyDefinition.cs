//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencyDefinition.cs
//**********************************************************

using Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefinition
     /// </summary>
    public partial class CompetencyDefinition : ICompetencyDefinition
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyFramework"/> model
        /// </summary>
        public Guid CompetencyFrameworkId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.URL non nullable property
        /// </summary>
        public System.String URL { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Type non nullable property
        /// </summary>
        public System.String Type { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Statement non nullable property
        /// </summary>
        public System.String Statement { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TypicalAgeRange non nullable property
        /// </summary>
        public System.String TypicalAgeRange { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TextComplexitySystem non nullable property
        /// </summary>
        public System.String TextComplexitySystem { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TextComplexityMinimumValue nullable property
        /// </summary>
        public System.Decimal? TextComplexityMinimumValue { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TextComplexityMaximumValue nullable property
        /// </summary>
        public System.Decimal? TextComplexityMaximumValue { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ConceptTerm non nullable property
        /// </summary>
        public System.String ConceptTerm { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ConceptKeyword non nullable property
        /// </summary>
        public System.String ConceptKeyword { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.License non nullable property
        /// </summary>
        public System.String License { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Notes non nullable property
        /// </summary>
        public System.String Notes { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefParent"/> model
        /// </summary>
        public Guid CompetencyDefParentId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.CompetencyDefParentCode non nullable property
        /// </summary>
        public System.String CompetencyDefParentCode { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.CompetencyDefParentUrl non nullable property
        /// </summary>
        public System.String CompetencyDefParentUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_CompetencyDefinition"/> model
        /// </summary>
        public Guid? ChildOf_CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.CurrentVersionIndicator nullable property
        /// </summary>
        public System.Boolean? CurrentVersionIndicator { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.PreviousVersionIdentifier non nullable property
        /// </summary>
        public System.String PreviousVersionIdentifier { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ValidStartDate nullable property
        /// </summary>
        public System.DateTime? ValidStartDate { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ValidEndDate nullable property
        /// </summary>
        public System.DateTime? ValidEndDate { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ShortName non nullable property
        /// </summary>
        public System.String ShortName { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.CompetencyDefSequence non nullable property
        /// </summary>
        public System.String CompetencyDefSequence { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TypeURL non nullable property
        /// </summary>
        public System.String TypeURL { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TypicalAgeRangeMaximum nullable property
        /// </summary>
        public System.Int32? TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TypicalAgeRangeMinimum nullable property
        /// </summary>
        public System.Int32? TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBloomsTaxonomyDomain"/> model
        /// </summary>
        public Guid? RefBloomsTaxonomyDomainId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMultipleIntelligenceType"/> model
        /// </summary>
        public Guid? RefMultipleIntelligenceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefNodeAccessibilityProfile"/> model
        /// </summary>
        public Guid? RefCompetencyDefNodeAccessibilityProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefTestabilityType"/> model
        /// </summary>
        public Guid? RefCompetencyDefTestabilityTypeId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
