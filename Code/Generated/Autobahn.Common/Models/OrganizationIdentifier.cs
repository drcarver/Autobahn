//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationIdentifier.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIdentifier
     /// </summary>
    public partial class OrganizationIdentifier : AutobahnBase, Interfaces.IOrganizationIdentifier
    {
        /// <summary>
        /// Defines the OrganizationIdentifier.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentificationSystem"/> model
        /// </summary>
        public Guid? RefOrganizationIdentificationSystemId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentifierType"/> model
        /// </summary>
        public Guid? RefOrganizationIdentifierTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
