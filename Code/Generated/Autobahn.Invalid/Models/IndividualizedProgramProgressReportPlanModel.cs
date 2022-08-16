//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressReportPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressReportPlan Model
     /// </summary>
    public partial class IndividualizedProgramProgressReportPlanModel : AutobahnBase, Interfaces.IIndividualizedProgramProgressReportPlan
    {
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
        public Guid? RefIPSPProgressReportScheduleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPSPProgressReportTypeId { get; set; }

    }
}
