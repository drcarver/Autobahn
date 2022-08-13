//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefIdentifier.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefIdentifier Interface
     /// </summary>
    public partial interface ICredentialDefIdentifier : IAutobahnBase
    {
        /// <summary>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </summary>
        Guid? RefCredentialIdentifierSystemId { get; set; }

    }
}
