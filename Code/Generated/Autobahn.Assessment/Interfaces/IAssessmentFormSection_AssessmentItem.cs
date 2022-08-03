//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentFormSection_AssessmentItem.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentFormSection_AssessmentItem
     /// </summary>
    public partial interface IAssessmentFormSection_AssessmentItem
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSectionItem"/> model
        /// </summary>
        Guid AssessmentFormSectionItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection_AssessmentItem.SequenceNumber non nullable property
        /// </summary>
        System.Int32 SequenceNumber { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection_AssessmentItem.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection_AssessmentItem.RecordEndDateTime nullable property
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
