//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressReport.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressReport
     /// </summary>
    public partial class IndividualizedProgramProgressReport : AutobahnBase, Interfaces.IIndividualizedProgramProgressReport
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReportPlan"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportPlanId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramProgressReport.ProgressDescription non nullable property
        /// </summary>
        public System.String ProgressDescription { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramProgressReport.ProgressReportDate nullable property
        /// </summary>
        public System.DateTime? ProgressReportDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportType"/> model
        /// </summary>
        public Guid? RefIPSPProgressReportTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
