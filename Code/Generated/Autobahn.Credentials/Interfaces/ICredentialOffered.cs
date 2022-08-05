//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialOffered.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialOffered
     /// </summary>
    public partial interface ICredentialOffered : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialIssuer"/> model
        /// </summary>
        Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// Defines the CredentialOffered.CredentialOfferedStartDate nullable property
        /// </summary>
        System.DateTime? CredentialOfferedStartDate { get; set; }

        /// <summary>
        /// Defines the CredentialOffered.CredentialOfferedEndDate nullable property
        /// </summary>
        System.DateTime? CredentialOfferedEndDate { get; set; }

    }
}
