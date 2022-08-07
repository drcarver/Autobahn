//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefIdentifierModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefIdentifierModel Interface
     /// </summary>
    public partial interface ICredentialDefIdentifierModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Defines the CredentialDefIdentifier.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialentifierSystem"/> model
        /// </summary>
        Guid? RefCredentialIdentifierSystemId { get; set; }

    }
}
