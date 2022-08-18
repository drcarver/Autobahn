//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerModel.cs
//* Name:       Credential Award Issuer Origin URL
//* Definition: The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
     /// </summary>
    public partial class CredentialIssuerModel : AutobahnBase, Interfaces.ICredentialIssuer
    {
        /// <summary>
        /// Credential Award Issuer Origin URL
        /// <para>
        /// The Uniform Resource Locator (URL) from which the qualification, achievement, personal or organizational quality, or aspect of an identity was issued.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19900">Credential Award Issuer Origin URL</a>
        /// </para>
        /// </summary>
        public System.String AwardIssuerOriginURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        public Guid? RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// Credential Issuer Revocation List URL
        /// <para>
        /// The URL to a document that includes a list of credential award assertions an issuer has revoked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20643">Credential Issuer Revocation List URL</a>
        /// </para>
        /// </summary>
        public System.String RevocationListURL { get; set; }

    }
}
