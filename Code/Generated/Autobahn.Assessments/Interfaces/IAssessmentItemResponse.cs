//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemResponse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentItemResponse Interface
     /// </summary>
    public partial interface IAssessmentItemResponse : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AidSetUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentItemResponseDescriptiveFeedbackDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DescriptiveFeedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FirstAttemptDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HintCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HintIncludedAnswer { get; set; }

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
         RefAssessItemResponseStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentItemResponseScoreStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProficiencyStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ResultXML { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScaffoldingItemFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScoreValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SecurityIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Value { get; set; }

    }
}
