//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramProgressReport.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramProgressReport Interface
     /// </summary>
    public partial interface IIndividualizedProgramProgressReport : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ProgressDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ProgressReportDate { get; set; }

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
         RefIPSPProgressReportTypeId { get; set; }

    }
}
