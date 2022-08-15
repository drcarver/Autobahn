//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramProgressReportModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramProgressReport Model
     /// </summary>
    public partial class IndividualizedProgramProgressReportModel : AutobahnBase, Interfaces.IIndividualizedProgramProgressReport
    {
        /// <summary>
        /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
        /// </summary>
        public System.DateTime? ProgressReportDate { get; set; }

    }
}
