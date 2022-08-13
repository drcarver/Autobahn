//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefIdentifier Model
     /// </summary>
    public partial class CredentialDefIdentifierModel : AutobahnBase, Interfaces.ICredentialDefIdentifier
    {
        /// <summary>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </summary>
        public Guid? RefCredentialIdentifierSystemId { get; set; }

    }
}
