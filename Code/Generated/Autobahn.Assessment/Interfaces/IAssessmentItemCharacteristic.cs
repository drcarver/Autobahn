//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemCharacteristic.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemCharacteristic
     /// </summary>
    public partial interface IAssessmentItemCharacteristic
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemCharacteristicType"/> model
        /// </summary>
        Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.Value non nullable property
        /// </summary>
        System.String Value { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.ResponseChoicePattern non nullable property
        /// </summary>
        System.String ResponseChoicePattern { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.RecordEndDateTime nullable property
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
