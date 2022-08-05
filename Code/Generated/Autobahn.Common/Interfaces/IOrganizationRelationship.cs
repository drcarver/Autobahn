//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationRelationship.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationRelationship
     /// </summary>
    public partial interface IOrganizationRelationship : IAutobahnBase
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

    }
}
