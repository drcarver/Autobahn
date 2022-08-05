//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemCharacteristic.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemCharacteristic
     /// </summary>
    public partial interface IAssessmentItemCharacteristic : IAutobahnBase
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

    }
}
