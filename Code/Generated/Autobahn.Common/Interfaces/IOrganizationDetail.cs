//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationDetail.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationDetail
     /// </summary>
    public partial interface IOrganizationDetail
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

        /// <summary>
        /// Defines the OrganizationDetail.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationDetail.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
