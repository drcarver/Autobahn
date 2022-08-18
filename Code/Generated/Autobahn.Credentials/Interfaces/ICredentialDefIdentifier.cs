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
        /// Credential Definition Alternate Name
        /// <para>
        /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
        /// </para>
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Credential Definition Identifier
        /// <para>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </para>
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialentifierSystem"/> model
        /// </summary>
        Guid? RefCredentialIdentifierSystemId { get; set; }

    }
}
