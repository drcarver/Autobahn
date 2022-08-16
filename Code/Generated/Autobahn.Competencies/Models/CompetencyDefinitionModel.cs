//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefinition Model
     /// </summary>
    public partial class CompetencyDefinitionModel : AutobahnBase, Interfaces.ICompetencyDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public  Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CompetencyDefParentCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CompetencyDefParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CompetencyDefParentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CompetencyDefSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ConceptKeyword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ConceptTerm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CurrentVersionIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PreviousVersionIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBloomsTaxonomyDomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCompetencyDefNodeAccessibilityProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCompetencyDefTestabilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMultipleIntelligenceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ShortName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Statement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TextComplexityMaximumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TextComplexityMinimumValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TextComplexitySystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TypeURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  URL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ValidEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ValidStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Version { get; set; }

    }
}
