//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramProgressReport.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressReport Interface
     /// </summary>
    public partial interface IIndividualizedProgramProgressReport : IAutobahnBase
    {
        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        Guid IndividualizedProgramProgressReportPlanId { get; set; }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        System.String ProgressDescription { get; set; }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        System.DateTime? ProgressReportDate { get; set; }

        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        Guid? RefIPSPProgressReportTypeId { get; set; }

    }
}