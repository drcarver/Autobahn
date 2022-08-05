//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemResponse.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemResponse
     /// </summary>
    public partial interface IAssessmentItemResponse : IAutobahnBase
    {
        /// <summary>
        /// Defines the AssessmentItemResponse.Value non nullable property
        /// </summary>
        System.String Value { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.ScoreValue non nullable property
        /// </summary>
        System.String ScoreValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessItemResponseStatus"/> model
        /// </summary>
        Guid? RefAssessItemResponseStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyStatus"/> model
        /// </summary>
        Guid? RefProficiencyStatusId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.AidSetUsed non nullable property
        /// </summary>
        System.String AidSetUsed { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.DescriptiveFeedback non nullable property
        /// </summary>
        System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.ScaffoldingItemFlag nullable property
        /// </summary>
        System.Boolean? ScaffoldingItemFlag { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.HintCount nullable property
        /// </summary>
        System.Int32? HintCount { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.HintIncludedAnswer nullable property
        /// </summary>
        System.Boolean? HintIncludedAnswer { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.Duration nullable property
        /// </summary>
        System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.FirstAttemptDuration nullable property
        /// </summary>
        System.TimeSpan? FirstAttemptDuration { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.StartTime nullable property
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.StartDate nullable property
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.SecurityIssue non nullable property
        /// </summary>
        System.String SecurityIssue { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        Guid AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.ResultXML non nullable property
        /// </summary>
        System.String ResultXML { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.AssessmentItemResponseDescriptiveFeedbackDate nullable property
        /// </summary>
        System.DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemResponseScoreStatus"/> model
        /// </summary>
        Guid? RefAssessmentItemResponseScoreStatusId { get; set; }

    }
}
