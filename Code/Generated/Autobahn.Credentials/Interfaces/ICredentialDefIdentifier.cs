//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefIdentifier.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefIdentifier
     /// </summary>
    public partial interface ICredentialDefIdentifier : IAutobahnBase
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
