//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemPossibleResponseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemPossibleResponseModel Interface
     /// </summary>
    public partial interface IAssessmentItemPossibleResponseModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.PossibleResponseOption non nullable property
        /// </summary>
        System.String PossibleResponseOption { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.Value non nullable property
        /// </summary>
        System.String Value { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.CorrectIndicator nullable property
        /// </summary>
        System.Boolean? CorrectIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.FeedbackMessage non nullable property
        /// </summary>
        System.String FeedbackMessage { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.SequenceNumber nullable property
        /// </summary>
        System.Int32? SequenceNumber { get; set; }

    }
}
