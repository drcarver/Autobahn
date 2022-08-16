//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPerformanceLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPerformanceLevel Interface
     /// </summary>
    public partial interface IAssessmentPerformanceLevel : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DescriptiveFeedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LowerCutScore { get; set; }

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
        Guid? ScoreMetric { get; set; }

        /// <summary>
        /// 
        /// </summary>
         UpperCutScore { get; set; }

    }
}
