//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   QuarterlyEmploymentRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The QuarterlyEmploymentRecord Model
     /// </summary>
    public partial class QuarterlyEmploymentRecordModel : AutobahnBase, Interfaces.IQuarterlyEmploymentRecord
    {
        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.Decimal? Earnings { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public Guid? RefEmployedPriorToEnrollmentId { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public Guid? RefEmploymentLocationId { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public Guid? RefERAdministrativeDataSourceId { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.DateTime? ReferencePeriodEndDate { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        public System.DateTime? ReferencePeriodStartDate { get; set; }

    }
}
