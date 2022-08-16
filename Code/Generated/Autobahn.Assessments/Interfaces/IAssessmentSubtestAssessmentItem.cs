//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSubtestAssessmentItem.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtestAssessmentItem Interface
     /// </summary>
    public partial interface IAssessmentSubtestAssessmentItem : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ItemWeightCorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ItemWeightIncorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ItemWeightNotAttempted { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
