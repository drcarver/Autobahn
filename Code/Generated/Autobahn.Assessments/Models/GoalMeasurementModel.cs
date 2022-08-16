//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The GoalMeasurement Model
     /// </summary>
    public partial class GoalMeasurementModel : AutobahnBase, Interfaces.IGoalMeasurement
    {
        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

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
        public  RefGoalMeasurementTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Schedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? SuccessCriteria { get; set; }

    }
}
