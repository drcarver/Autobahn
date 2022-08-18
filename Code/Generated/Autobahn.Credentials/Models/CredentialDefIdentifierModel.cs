//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierModel.cs
//***************************************************************************

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
        /// Credential Definition Alternate Name
        /// <para>
        /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
        /// </para>
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Credential Definition Identifier
        /// <para>
        /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
        /// </para>
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialentifierSystem"/> model
        /// </summary>
        public Guid? RefCredentialIdentifierSystemId { get; set; }

    }
}
