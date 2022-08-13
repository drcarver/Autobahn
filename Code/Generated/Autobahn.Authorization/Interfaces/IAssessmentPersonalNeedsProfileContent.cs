//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileContent.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileContent Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileContent : IAutobahnBase
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? ChunkingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? ChunkingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        Guid? RefAssessmentNeedHazardTypeId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        Guid? RefAssessmentNeedSupportToolId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        Guid? RefKeywordTranslationsLanguageId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        System.Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

    }
}
