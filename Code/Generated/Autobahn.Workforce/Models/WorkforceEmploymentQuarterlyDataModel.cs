//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Workforce.Models
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyData Model
     /// </summary>
    public partial class WorkforceEmploymentQuarterlyDataModel : AutobahnBase, Interfaces.IWorkforceEmploymentQuarterlyData
    {
        /// <summary>
        /// 
        /// </summary>
        public  EmployedInMultipleJobsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MilitaryEnlistmentAfterExit { get; set; }

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
        public  RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get; set; }

    }
}
