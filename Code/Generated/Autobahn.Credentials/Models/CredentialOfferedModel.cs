//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialOffered Model
     /// </summary>
    public partial class CredentialOfferedModel : AutobahnBase, Interfaces.ICredentialOffered
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
        /// Credential Award Issuer Origin URL
        /// <para>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19900">Credential Award Issuer Origin URL</a>
        /// </para>
        /// </summary>
        public Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// Credential Offered End Date
        /// <para>
        /// The last date a credential was offered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20893">Credential Offered End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CredentialOfferedEndDate { get; set; }

        /// <summary>
        /// Credential Offered Start Date
        /// <para>
        /// The first date a credential was offered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20892">Credential Offered Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CredentialOfferedStartDate { get; set; }

    }
}
