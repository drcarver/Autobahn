//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramProgressReportPlan.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressReportPlan
     /// </summary>
    public partial interface IIndividualizedProgramProgressReportPlan : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
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
