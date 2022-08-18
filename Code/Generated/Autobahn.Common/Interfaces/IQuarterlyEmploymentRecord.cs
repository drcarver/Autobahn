//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IQuarterlyEmploymentRecord.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IQuarterlyEmploymentRecord Interface
     /// </summary>
    public partial interface IQuarterlyEmploymentRecord : IAutobahnBase
    {
        /// <summary>
        /// Quarterly Earnings
        /// <para>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19991">Quarterly Earnings</a>
        /// </para>
        /// </summary>
        System.Decimal? Earnings { get; set; }

        /// <summary>
        /// Employment NAICS Code
        /// <para>
        /// The North American Industry Classification System (NAICS) code associated with an individual's employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20070">Employment NAICS Code</a>
        /// </para>
        /// </summary>
        System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedPriorToEnrollment"/> model
        /// </summary>
        Guid? RefEmployedPriorToEnrollmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentLocation"/> model
        /// </summary>
        Guid? RefEmploymentLocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERAdministrativeDataSource"/> model
        /// </summary>
        Guid? RefERAdministrativeDataSourceId { get; set; }

        /// <summary>
        /// Employment Record Reference Period End Date
        /// <para>
        /// The year, month, and day of the last day of the employment record reference period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19995">Employment Record Reference Period End Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ReferencePeriodEndDate { get; set; }

        /// <summary>
        /// Employment Record Reference Period Start Date
        /// <para>
        /// The year, month, and day of the first day of the employment record reference period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19994">Employment Record Reference Period Start Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ReferencePeriodStartDate { get; set; }

    }
}
