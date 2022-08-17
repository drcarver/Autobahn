//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRoleStatus.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleStatus Interface
     /// </summary>
    public partial interface IRoleStatus : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefRoleStatus"/> model
        /// </summary>
        Guid? RefRoleStatusId { get; set; }

        /// <summary>
        /// Employment End Date
        /// <para>
        /// The year, month and day on which a person ended self-employment or employment with an organization or institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19794">Employment End Date</a>
        /// </para>
        /// </summary>
        System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Employment Start Date
        /// <para>
        /// The year, month and day on which a person began self-employment or employment with an organization or institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19345">Employment Start Date</a>
        /// </para>
        /// </summary>
        System.DateTime StatusStartDate { get; set; }

    }
}
