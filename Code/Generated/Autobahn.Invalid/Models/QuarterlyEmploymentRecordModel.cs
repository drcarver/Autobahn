//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   QuarterlyEmploymentRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The QuarterlyEmploymentRecord Model
     /// </summary>
    public partial class QuarterlyEmploymentRecordModel : AutobahnBase, Interfaces.IQuarterlyEmploymentRecord
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Earnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EmploymentNAICSCode { get; set; }

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
        public  RefEmployedPriorToEnrollmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEmploymentLocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefERAdministrativeDataSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ReferencePeriodEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ReferencePeriodStartDate { get; set; }

    }
}
