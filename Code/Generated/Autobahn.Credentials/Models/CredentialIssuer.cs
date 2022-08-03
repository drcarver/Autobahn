//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialIssuer.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialIssuer
     /// </summary>
    public partial class CredentialIssuer : ICredentialIssuer
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.AwardIssuerOriginURL non nullable property
        /// </summary>
        public System.String AwardIssuerOriginURL { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.RevocationListURL non nullable property
        /// </summary>
        public System.String RevocationListURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.RecordEndDateTime nullable property
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
