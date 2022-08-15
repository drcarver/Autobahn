//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalPerformanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The GoalPerformance Model
     /// </summary>
    public partial class GoalPerformanceModel : AutobahnBase, Interfaces.IGoalPerformance
    {
        /// <summary>
        /// Current performance explanation related to the annual goal or short-term objectives.
        /// </summary>
        public System.String CurrentPerformanceDescription { get; set; }

    }
}
