//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IQuarterlyEmploymentRecord.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IQuarterlyEmploymentRecord Interface
     /// </summary>
    public partial interface IQuarterlyEmploymentRecord : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Earnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EmploymentNAICSCode { get; set; }

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
         RefEmployedPriorToEnrollmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEmploymentLocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefERAdministrativeDataSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ReferencePeriodEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ReferencePeriodStartDate { get; set; }

    }
}
