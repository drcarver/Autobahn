//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentForm_AssessmentFormSection.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentForm_AssessmentFormSection
     /// </summary>
    public partial interface IAssessmentForm_AssessmentFormSection
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Defines the AssessmentForm_AssessmentFormSection.SequenceNumber nullable property
        /// </summary>
        System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// Defines the AssessmentForm_AssessmentFormSection.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentForm_AssessmentFormSection.RecordEndDateTime nullable property
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
