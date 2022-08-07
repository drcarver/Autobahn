//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationImageModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationImageModel Interface
     /// </summary>
    public partial interface IOrganizationImageModel : IAutobahnBase
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
