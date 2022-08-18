//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramProgressReportPlan.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressReportPlan Interface
     /// </summary>
    public partial interface IIndividualizedProgramProgressReportPlan : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportSchedule"/> model
        /// </summary>
        Guid? RefIPSPProgressReportScheduleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportType"/> model
        /// </summary>
        Guid? RefIPSPProgressReportTypeId { get; set; }

    }
}
