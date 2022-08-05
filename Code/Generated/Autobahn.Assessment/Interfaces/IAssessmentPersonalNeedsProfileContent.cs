//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentPersonalNeedsProfileContent.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileContent
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileContent : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedHazardType"/> model
        /// </summary>
        Guid? RefAssessmentNeedHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedSupportTool"/> model
        /// </summary>
        Guid? RefAssessmentNeedSupportToolId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.CognitiveGuidanceActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.CognitiveGuidanceAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ScaffoldingAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ScaffoldingActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ChunkingAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? ChunkingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ChunkingActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? ChunkingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.KeywordEmphasisAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.KeywordEmphasisActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ReducedAnswersAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.ReducedAnswersActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.NegativesRemovedAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.NegativesRemovedActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKeywordTranslationsLanguage"/> model
        /// </summary>
        Guid? RefKeywordTranslationsLanguageId { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.KeywordTranslationsAssignedSupportIndicator nullable property
        /// </summary>
        System.Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentPersonalNeedsProfileContent.KeywordTranslationsActivateByDefaultIndicator nullable property
        /// </summary>
        System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

    }
}
