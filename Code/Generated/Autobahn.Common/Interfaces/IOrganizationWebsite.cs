//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationWebsite.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationWebsite
     /// </summary>
    public partial interface IOrganizationWebsite : IAutobahnBase
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
