//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefAgentCredential.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefAgentCredential Interface
     /// </summary>
    public partial interface ICredentialDefAgentCredential : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefAgent"/> model
        /// </summary>
        Guid CredentialDefAgentId { get; set; }

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

    }
}
