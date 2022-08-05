//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   ICompetencyDefinition.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefinition
     /// </summary>
    public partial interface ICompetencyDefinition : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyFramework"/> model
        /// </summary>
        Guid CompetencyFrameworkId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.URL non nullable property
        /// </summary>
        System.String URL { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Type non nullable property
        /// </summary>
        System.String Type { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Statement non nullable property
        /// </summary>
        System.String Statement { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TypicalAgeRange non nullable property
        /// </summary>
        System.String TypicalAgeRange { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TextComplexitySystem non nullable property
        /// </summary>
        System.String TextComplexitySystem { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TextComplexityMinimumValue nullable property
        /// </summary>
        System.Decimal? TextComplexityMinimumValue { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TextComplexityMaximumValue nullable property
        /// </summary>
        System.Decimal? TextComplexityMaximumValue { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ConceptTerm non nullable property
        /// </summary>
        System.String ConceptTerm { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ConceptKeyword non nullable property
        /// </summary>
        System.String ConceptKeyword { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.License non nullable property
        /// </summary>
        System.String License { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.Notes non nullable property
        /// </summary>
        System.String Notes { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefParent"/> model
        /// </summary>
        Guid CompetencyDefParentId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.CompetencyDefParentCode non nullable property
        /// </summary>
        System.String CompetencyDefParentCode { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.CompetencyDefParentUrl non nullable property
        /// </summary>
        System.String CompetencyDefParentUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_CompetencyDefinition"/> model
        /// </summary>
        Guid? ChildOf_CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.CurrentVersionIndicator nullable property
        /// </summary>
        System.Boolean? CurrentVersionIndicator { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.PreviousVersionIdentifier non nullable property
        /// </summary>
        System.String PreviousVersionIdentifier { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ValidStartDate nullable property
        /// </summary>
        System.DateTime? ValidStartDate { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ValidEndDate nullable property
        /// </summary>
        System.DateTime? ValidEndDate { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.ShortName non nullable property
        /// </summary>
        System.String ShortName { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.CompetencyDefSequence non nullable property
        /// </summary>
        System.String CompetencyDefSequence { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TypeURL non nullable property
        /// </summary>
        System.String TypeURL { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TypicalAgeRangeMaximum nullable property
        /// </summary>
        System.Int32? TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// Defines the CompetencyDefinition.TypicalAgeRangeMinimum nullable property
        /// </summary>
        System.Int32? TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBloomsTaxonomyDomain"/> model
        /// </summary>
        Guid? RefBloomsTaxonomyDomainId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMultipleIntelligenceType"/> model
        /// </summary>
        Guid? RefMultipleIntelligenceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefNodeAccessibilityProfile"/> model
        /// </summary>
        Guid? RefCompetencyDefNodeAccessibilityProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCompetencyDefTestabilityType"/> model
        /// </summary>
        Guid? RefCompetencyDefTestabilityTypeId { get; set; }

    }
}
