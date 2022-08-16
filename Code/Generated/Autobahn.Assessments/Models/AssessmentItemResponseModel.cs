//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemResponse Model
     /// </summary>
    public partial class AssessmentItemResponseModel : AutobahnBase, Interfaces.IAssessmentItemResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public  AidSetUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssessmentItemResponseDescriptiveFeedbackDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DescriptiveFeedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FirstAttemptDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HintCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HintIncludedAnswer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessItemResponseStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentItemResponseScoreStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProficiencyStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ResultXML { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScaffoldingItemFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScoreValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SecurityIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Value { get; set; }

    }
}
