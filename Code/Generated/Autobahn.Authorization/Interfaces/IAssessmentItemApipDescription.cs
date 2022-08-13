//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemApipDescription.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentItemApipDescription Interface
     /// </summary>
    public partial interface IAssessmentItemApipDescription : IAutobahnBase
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? AslIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? AslOnDemandIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid AssessmentItemApipId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? BrailleIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? ChunkingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? ChunkingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? GraphicsOnlyIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? NonVisualIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid? RefHazardTypeId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid? RefKeywordTranslationLanguageId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        Guid? RefSupportToolTypeId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? SignedEnglishIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? SignedEnglishOnDemandIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? TextGraphicsIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? TextOnlyIndicator { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        System.Boolean? TextOnlyOnDemandIndicator { get; set; }

    }
}
