//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationLocation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationLocation
     /// </summary>
    public partial class OrganizationLocation : IOrganizationLocation
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
        /// Defines the OrganizationLocation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationLocation.RecordEndDateTime nullable property
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
