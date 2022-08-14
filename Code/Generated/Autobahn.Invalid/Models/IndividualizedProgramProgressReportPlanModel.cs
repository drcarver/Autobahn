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
        /// Frequency by which parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan year.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Frequency by which parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan year.
        /// </summary>
        public Guid? RefIPSPProgressReportScheduleId { get; set; }

        /// <summary>
        /// Frequency by which parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan year.
        /// </summary>
        public Guid? RefIPSPProgressReportTypeId { get; set; }

    }
}
