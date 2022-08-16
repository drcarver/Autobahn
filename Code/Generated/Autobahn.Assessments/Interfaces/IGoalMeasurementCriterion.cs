//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoalMeasurementCriterion.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IGoalMeasurementCriterion Interface
     /// </summary>
    public partial interface IGoalMeasurementCriterion : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AccuracyPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AttemptsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Metric { get; set; }

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
         SuccessCount { get; set; }

    }
}
