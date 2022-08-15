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
        /// The percent of correct results that will be considered to represent successful achievement of a goal.
        /// </summary>
        public System.Decimal? AccuracyPercent { get; set; }

    }
}
