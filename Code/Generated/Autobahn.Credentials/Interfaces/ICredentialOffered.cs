//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialOffered.cs
//**********************************************************

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialOffered
     /// </summary>
    public partial interface ICredentialOffered
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialOffered"/> model
        /// </summary>
        Guid CredentialOfferedId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialIssuer"/> model
        /// </summary>
        Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
    System.DateTime? CredentialOfferedStartDate { get; set; }

        /// <summary>
        /// The last date a credential was offered.
        /// </summary>
    System.DateTime? CredentialOfferedEndDate { get; set; }

        /// <summary>
        /// Defines the CredentialOffered.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialOffered.RecordEndDateTime nullable property
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
