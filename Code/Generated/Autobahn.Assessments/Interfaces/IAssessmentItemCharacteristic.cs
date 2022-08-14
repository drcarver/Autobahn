//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemCharacteristic.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItemCharacteristic Interface
     /// </summary>
    public partial interface IAssessmentItemCharacteristic : IAutobahnBase
    {
        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        System.String ResponseChoicePattern { get; set; }

        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        System.String Value { get; set; }

    }
}
