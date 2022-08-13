//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemPossibleResponseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentItemPossibleResponse Model
     /// </summary>
    public partial class AssessmentItemPossibleResponseModel : AutobahnBase, Interfaces.IAssessmentItemPossibleResponse
    {
        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.Boolean? CorrectIndicator { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.String FeedbackMessage { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.String PossibleResponseOption { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.String Value { get; set; }

    }
}
