//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressGoalModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressGoal Model
     /// </summary>
    public partial class IndividualizedProgramProgressGoalModel : AutobahnBase, Interfaces.IIndividualizedProgramProgressGoal
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
