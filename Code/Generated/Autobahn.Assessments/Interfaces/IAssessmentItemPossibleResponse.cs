//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemPossibleResponse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItemPossibleResponse Interface
     /// </summary>
    public partial interface IAssessmentItemPossibleResponse : IAutobahnBase
    {
        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        System.Boolean? CorrectIndicator { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        System.String FeedbackMessage { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        System.String PossibleResponseOption { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        System.String Value { get; set; }

    }
}
