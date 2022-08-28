//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationWebsite.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationWebsite Interface
     /// </summary>
    public partial interface IOrganizationWebsite : IAutobahnBase
    {
        #region IOrganizationWebsite
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Web Site Address
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of a Web page.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19300">Web Site Address</a>
        /// </para>
        /// </summary>
        System.String Website { get; set; }

        #endregion
    }
}
