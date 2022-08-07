//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationDetailModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationDetailModel Interface
     /// </summary>
    public partial interface IOrganizationDetailModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationDetail.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the OrganizationDetail.ShortName non nullable property
        /// </summary>
        System.String ShortName { get; set; }

        /// <summary>
        /// Defines the OrganizationDetail.RegionGeoJSON non nullable property
        /// </summary>
        System.String RegionGeoJSON { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
        /// </summary>
        Guid? RefOrganizationTypeId { get; set; }

    }
}
