//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressReportPlanModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressReportPlan Model
     /// </summary>
    public partial class IndividualizedProgramProgressReportPlanModel : AutobahnBase, Interfaces.IIndividualizedProgramProgressReportPlan
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
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

    }
}
