//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemPossibleResponse.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemPossibleResponse
     /// </summary>
    public partial interface IAssessmentItemPossibleResponse
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

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemPossibleResponse.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
