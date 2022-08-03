//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialIssuer.cs
//**********************************************************

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialIssuer
     /// </summary>
    public partial interface ICredentialIssuer
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.AwardIssuerOriginURL non nullable property
        /// </summary>
        System.String AwardIssuerOriginURL { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.RevocationListURL non nullable property
        /// </summary>
        System.String RevocationListURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        Guid? RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialIssuer.RecordEndDateTime nullable property
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
