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
        /// 
        /// </summary>
        public Guid? CurrentPerformanceDescription { get; set; }

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
        public  RefGoalStatusTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Status { get; set; }

    }
}
