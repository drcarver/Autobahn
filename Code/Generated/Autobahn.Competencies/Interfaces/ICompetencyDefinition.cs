//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefinition.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefinition Interface
     /// </summary>
    public partial interface ICompetencyDefinition : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CompetencyDefParentCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CompetencyDefParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CompetencyDefParentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CompetencyDefSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ConceptKeyword { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ConceptTerm { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CurrentVersionIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         License { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PreviousVersionIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBloomsTaxonomyDomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCompetencyDefNodeAccessibilityProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCompetencyDefTestabilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMultipleIntelligenceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ShortName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Statement { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TextComplexityMaximumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TextComplexityMinimumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TextComplexitySystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TypeURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// 
        /// </summary>
         URL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ValidEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ValidStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Version { get; set; }

    }
}
