//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemApipDescriptionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemApipDescriptionModel Interface
     /// </summary>
    public partial interface IAssessmentItemApipDescriptionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemApip"/> model
        /// </summary>
        Guid AssessmentItemApipId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.CognitiveGuidanceActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.CognitiveGuidanceAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ScaffoldingAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ScaffoldingActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ChunkingAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? ChunkingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ChunkingActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? ChunkingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.KeywordEmphasisAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.KeywordEmphasisActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ReducedAnswersAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.ReducedAnswersActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.NegativesRemovedAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.NegativesRemovedActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.KeywordTranslationsAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.KeywordTranslationsActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.BrailleIndicator nullable property
        /// </summary>
        System.Boolean? BrailleIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.TextOnlyIndicator nullable property
        /// </summary>
        System.Boolean? TextOnlyIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.TextOnlyOnDemandIndicator nullable property
        /// </summary>
        System.Boolean? TextOnlyOnDemandIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.TextGraphicsIndicator nullable property
        /// </summary>
        System.Boolean? TextGraphicsIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.GraphicsOnlyIndicator nullable property
        /// </summary>
        System.Boolean? GraphicsOnlyIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.NonVisualIndicator nullable property
        /// </summary>
        System.Boolean? NonVisualIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.AslIndicator nullable property
        /// </summary>
        System.Boolean? AslIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.AslOnDemandIndicator nullable property
        /// </summary>
        System.Boolean? AslOnDemandIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.SignedEnglishIndicator nullable property
        /// </summary>
        System.Boolean? SignedEnglishIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemApipDescription.SignedEnglishOnDemandIndicator nullable property
        /// </summary>
        System.Boolean? SignedEnglishOnDemandIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHazardType"/> model
        /// </summary>
        Guid? RefHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSupportToolType"/> model
        /// </summary>
        Guid? RefSupportToolTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationLanguage"/> model
        /// </summary>
        Guid? RefKeywordTranslationLanguageId { get; set; }

    }
}
