//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemResponse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentItemResponse Interface
     /// </summary>
    public partial interface IAssessmentItemResponse : IAutobahnBase
    {
        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.String AidSetUsed { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        Guid AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.TimeSpan? FirstAttemptDuration { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.Int32? HintCount { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.Boolean? HintIncludedAnswer { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        Guid? RefAssessItemResponseStatusId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        Guid? RefAssessmentItemResponseScoreStatusId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        Guid? RefProficiencyStatusId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.String ResultXML { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.Boolean? ScaffoldingItemFlag { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.String ScoreValue { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.String SecurityIssue { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        System.String Value { get; set; }

    }
}
