//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationRelationship.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationRelationship
     /// </summary>
    public partial interface IOrganizationRelationship
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Parent_Organization"/> model
        /// </summary>
        Guid Parent_OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationRelationship"/> model
        /// </summary>
        Guid? RefOrganizationRelationshipId { get; set; }

        /// <summary>
        /// Defines the OrganizationRelationship.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationRelationship.RecordEndDateTime nullable property
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
