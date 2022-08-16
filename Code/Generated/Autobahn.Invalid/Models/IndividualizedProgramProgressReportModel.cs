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
        /// 
        /// </summary>
        public  ProgressDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ProgressReportDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIPSPProgressReportTypeId { get; set; }

    }
}
