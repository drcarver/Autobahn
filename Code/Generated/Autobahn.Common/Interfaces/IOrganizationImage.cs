//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationImage.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationImage
     /// </summary>
    public partial interface IOrganizationImage : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationImage.URL non nullable property
        /// </summary>
        System.String URL { get; set; }

    }
}
