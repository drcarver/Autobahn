//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationWebsite.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationWebsite Interface
     /// </summary>
    public partial interface IOrganizationWebsite : IAutobahnBase
    {
        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of a Web page.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of a Web page.
        /// </summary>
        System.String Website { get; set; }

    }
}
