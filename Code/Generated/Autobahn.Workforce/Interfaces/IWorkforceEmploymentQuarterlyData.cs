//***************************************************************************
//* DomainName: Workforce Interfaces (used by both models and View Models
//* FileName:   IWorkforceEmploymentQuarterlyData.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceEmploymentQuarterlyData Interface
     /// </summary>
    public partial interface IWorkforceEmploymentQuarterlyData : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         EmployedInMultipleJobsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MilitaryEnlistmentAfterExit { get; set; }

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
         RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

    }
}
