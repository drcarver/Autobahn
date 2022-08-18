//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialIssuer.cs
//* Name:       Credential Award Issuer Origin URL
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface ICredentialIssuer : IAutobahnBase
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
        System.String AwardIssuerOriginURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLOrganizationType"/> model
        /// </summary>
        Guid? RefCTDLOrganizationTypeId { get; set; }

        /// <summary>
        /// Credential Issuer Revocation List URL
        /// <para>
        /// The URL to a document that includes a list of credential award assertions an issuer has revoked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20643">Credential Issuer Revocation List URL</a>
        /// </para>
        /// </summary>
        System.String RevocationListURL { get; set; }

    }
}
