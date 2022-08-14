//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramProgressReportPlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressReportPlan Interface
     /// </summary>
    public partial interface IIndividualizedProgramProgressReportPlan : IAutobahnBase
    {
        /// <summary>
        /// Frequency by which parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan year.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Frequency by which parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan year.
        /// </summary>
        Guid? RefIPSPProgressReportScheduleId { get; set; }

        /// <summary>
        /// Frequency by which parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan year.
        /// </summary>
        Guid? RefIPSPProgressReportTypeId { get; set; }

    }
}
