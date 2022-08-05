//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramProgressReport.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressReport
     /// </summary>
    public partial interface IIndividualizedProgramProgressReport : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReportPlan"/> model
        /// </summary>
        Guid IndividualizedProgramProgressReportPlanId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramProgressReport.ProgressDescription non nullable property
        /// </summary>
        System.String ProgressDescription { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramProgressReport.ProgressReportDate nullable property
        /// </summary>
        System.DateTime? ProgressReportDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportType"/> model
        /// </summary>
        Guid? RefIPSPProgressReportTypeId { get; set; }

    }
}
