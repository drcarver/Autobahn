//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationIdentifier.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIdentifier
     /// </summary>
    public partial class OrganizationIdentifier : IOrganizationIdentifier
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
        /// Defines the OrganizationIdentifier.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationIdentifier.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
