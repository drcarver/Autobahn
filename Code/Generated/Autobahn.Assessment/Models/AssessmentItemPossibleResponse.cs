//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemPossibleResponse.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemPossibleResponse
     /// </summary>
    public partial class AssessmentItemPossibleResponse : AutobahnBase, Interfaces.IAssessmentItemPossibleResponse
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.PossibleResponseOption non nullable property
        /// </summary>
        public System.String PossibleResponseOption { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.Value non nullable property
        /// </summary>
        public System.String Value { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.CorrectIndicator nullable property
        /// </summary>
        public System.Boolean? CorrectIndicator { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.FeedbackMessage non nullable property
        /// </summary>
        public System.String FeedbackMessage { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.SequenceNumber nullable property
        /// </summary>
        public System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
