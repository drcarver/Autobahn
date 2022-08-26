//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationOperationalStatus.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationOperationalStatus Interface
     /// </summary>
    public partial interface IOrganizationOperationalStatus : IAutobahnBase
    {
        /// <summary>
        /// Operation Date
        /// <para>
        /// The year, month and day on which a program or center began operation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19350">Operation Date</a>
        /// </para>
        /// </summary>
        DateTime? OperationalStatusEffectiveDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Local Education Agency Operational Status
        /// <para>
        /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19174">Local Education Agency Operational Status</a>
        /// </para>
        /// </summary>
        Guid RefOperationalStatusId { get; set; }

    }
}
