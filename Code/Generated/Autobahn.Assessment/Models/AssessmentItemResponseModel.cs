//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemResponseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemResponse Model
     /// </summary>
    public partial class AssessmentItemResponseModel : AutobahnBase, Interfaces.IAssessmentItemResponseModel
    {
        /// <summary>
        /// Defines the AssessmentItemResponse.Value non nullable property
        /// </summary>
        public System.String Value { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.ScoreValue non nullable property
        /// </summary>
        public System.String ScoreValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessItemResponseStatus"/> model
        /// </summary>
        public Guid? RefAssessItemResponseStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyStatus"/> model
        /// </summary>
        public Guid? RefProficiencyStatusId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.AidSetUsed non nullable property
        /// </summary>
        public System.String AidSetUsed { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.DescriptiveFeedback non nullable property
        /// </summary>
        public System.String DescriptiveFeedback { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.ScaffoldingItemFlag nullable property
        /// </summary>
        public System.Boolean? ScaffoldingItemFlag { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.HintCount nullable property
        /// </summary>
        public System.Int32? HintCount { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.HintIncludedAnswer nullable property
        /// </summary>
        public System.Boolean? HintIncludedAnswer { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.Duration nullable property
        /// </summary>
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.FirstAttemptDuration nullable property
        /// </summary>
        public System.TimeSpan? FirstAttemptDuration { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.StartTime nullable property
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.StartDate nullable property
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.SecurityIssue non nullable property
        /// </summary>
        public System.String SecurityIssue { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentParticipantSession"/> model
        /// </summary>
        public Guid AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.ResultXML non nullable property
        /// </summary>
        public System.String ResultXML { get; set; }

        /// <summary>
        /// Defines the AssessmentItemResponse.AssessmentItemResponseDescriptiveFeedbackDate nullable property
        /// </summary>
        public System.DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemResponseScoreStatus"/> model
        /// </summary>
        public Guid? RefAssessmentItemResponseScoreStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
