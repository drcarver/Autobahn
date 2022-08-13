//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemResponseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentItemResponse Model
     /// </summary>
    public partial class AssessmentItemResponseModel : AutobahnBase, Interfaces.IAssessmentItemResponse
    {
        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String AidSetUsed { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public Guid AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.TimeSpan? FirstAttemptDuration { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.Int32? HintCount { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.Boolean? HintIncludedAnswer { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public Guid? RefAssessItemResponseStatusId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public Guid? RefAssessmentItemResponseScoreStatusId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public Guid? RefProficiencyStatusId { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String ResultXML { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.Boolean? ScaffoldingItemFlag { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String ScoreValue { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String SecurityIssue { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.String Value { get; set; }

    }
}
