//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramProgressReportModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressReport Model
     /// </summary>
    public partial class IndividualizedProgramProgressReportModel : AutobahnBase, Interfaces.IIndividualizedProgramProgressReport
    {
        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        public Guid IndividualizedProgramProgressReportPlanId { get; set; }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        public System.String ProgressDescription { get; set; }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        public System.DateTime? ProgressReportDate { get; set; }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        public Guid? RefIPSPProgressReportTypeId { get; set; }

    }
}
