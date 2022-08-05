//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressReportPlan.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressReportPlan
     /// </summary>
    public partial class IndividualizedProgramProgressReportPlan : AutobahnBase, Interfaces.IIndividualizedProgramProgressReportPlan
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportSchedule"/> model
        /// </summary>
        public Guid? RefIPSPProgressReportScheduleId { get; set; }

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
