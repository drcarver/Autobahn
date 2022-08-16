//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentSession.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentSession Interface
     /// </summary>
    public partial interface IAssessmentSession : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ActualEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ActualStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AllottedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Location { get; set; }

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
        Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentSessionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScheduledEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScheduledStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SecurityIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SpecialEventDescription { get; set; }

    }
}
