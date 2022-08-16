//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The GoalMeasurementCriterion Model
     /// </summary>
    public partial class GoalMeasurementCriterionModel : AutobahnBase, Interfaces.IGoalMeasurementCriterion
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AccuracyPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AttemptsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Metric { get; set; }

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
        public  SuccessCount { get; set; }

    }
}
