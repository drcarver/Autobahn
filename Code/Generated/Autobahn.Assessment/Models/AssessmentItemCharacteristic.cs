//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemCharacteristic.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemCharacteristic
     /// </summary>
    public partial class AssessmentItemCharacteristic : IAssessmentItemCharacteristic
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemCharacteristicType"/> model
        /// </summary>
        public Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.Value non nullable property
        /// </summary>
        public System.String Value { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.ResponseChoicePattern non nullable property
        /// </summary>
        public System.String ResponseChoicePattern { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
