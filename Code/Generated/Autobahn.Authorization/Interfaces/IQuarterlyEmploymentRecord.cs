//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IQuarterlyEmploymentRecord.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IQuarterlyEmploymentRecord Interface
     /// </summary>
    public partial interface IQuarterlyEmploymentRecord : IAutobahnBase
    {
        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        System.Decimal? Earnings { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        Guid? RefEmployedPriorToEnrollmentId { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        Guid? RefEmploymentLocationId { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        Guid? RefERAdministrativeDataSourceId { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        System.DateTime? ReferencePeriodEndDate { get; set; }

        /// <summary>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </summary>
        System.DateTime? ReferencePeriodStartDate { get; set; }

    }
}
