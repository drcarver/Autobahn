//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationLocation.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationLocation
     /// </summary>
    public partial class OrganizationLocation : AutobahnBase, Interfaces.IOrganizationLocation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Location"/> model
        /// </summary>
        public Guid LocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationLocationType"/> model
        /// </summary>
        public Guid? RefOrganizationLocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
