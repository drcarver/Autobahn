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
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefIPSPProgressReportScheduleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIPSPProgressReportTypeId { get; set; }

    }
}
