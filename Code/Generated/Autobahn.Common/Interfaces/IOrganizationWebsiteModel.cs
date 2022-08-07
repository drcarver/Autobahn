//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationWebsiteModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationWebsiteModel Interface
     /// </summary>
    public partial interface IOrganizationWebsiteModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationWebsite.Website non nullable property
        /// </summary>
        System.String Website { get; set; }

    }
}
