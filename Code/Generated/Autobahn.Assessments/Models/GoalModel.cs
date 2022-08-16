//**********************************************************
//* DomainName: Assessments
//* FileName:   GoalModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Goal Model
     /// </summary>
    public partial class GoalModel : AutobahnBase, Interfaces.IGoal
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EndDate { get; set; }

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
        public  StartDate { get; set; }

    }
}
