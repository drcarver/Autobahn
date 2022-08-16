//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemPossibleResponse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItemPossibleResponse Interface
     /// </summary>
    public partial interface IAssessmentItemPossibleResponse : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CorrectIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? FeedbackMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PossibleResponseOption { get; set; }

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
         SequenceNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Value { get; set; }

    }
}
