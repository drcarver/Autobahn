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
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ResponseChoicePattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Value { get; set; }

    }
}
