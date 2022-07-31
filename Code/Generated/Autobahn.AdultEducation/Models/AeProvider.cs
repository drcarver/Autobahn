//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeProvider.cs
//**********************************************************

using Autobahn.AdultEducation.Interfaces;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeProvider
     /// </summary>
    public partial class AeProvider : IAeProvider
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AeProvider"/> model
        /// </summary>
        public Guid AeProviderId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        public Guid RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// Defines the AeProvider.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AeProvider.RecordEndDateTime nullable property
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
