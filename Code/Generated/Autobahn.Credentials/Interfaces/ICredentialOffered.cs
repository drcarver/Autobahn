//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialOffered.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialOffered Interface
     /// </summary>
    public partial interface ICredentialOffered : IAutobahnBase
    {
        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        System.DateTime? CredentialOfferedEndDate { get; set; }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        System.DateTime? CredentialOfferedStartDate { get; set; }

    }
}
