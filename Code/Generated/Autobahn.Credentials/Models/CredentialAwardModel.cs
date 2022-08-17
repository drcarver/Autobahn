//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardModel.cs
//* Name:       Credential Advanced Standing Description
//* Definition: A description of a credential that reduced the time or cost of attaining this credential.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// A description of a credential that reduced the time or cost of attaining this credential.
     /// </summary>
    public partial class CredentialAwardModel : AutobahnBase, Interfaces.ICredentialAward
    {
        /// <summary>
        /// Credential Advanced Standing Description
        /// <para>
        /// A description of a credential that reduced the time or cost of attaining this credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20715">Credential Advanced Standing Description</a>
        /// </para>
        /// </summary>
        public System.String AdvancedStandingDescription { get; set; }

        /// <summary>
        /// Credential Advanced Standing URL
        /// <para>
        /// A URL that resolves to information about a credential that reduced the time or cost of attaining this credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20716">Credential Advanced Standing URL</a>
        /// </para>
        /// </summary>
        public System.String AdvancedStandingURL { get; set; }

        /// <summary>
        /// Credential Award Approver Name
        /// <para>
        /// Pronouncement of a favorable judgment by the agent being referenced.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20718">Credential Award Approver Name</a>
        /// </para>
        /// </summary>
        public System.String ApproverName { get; set; }

        /// <summary>
        /// Credential Completion Date
        /// <para>
        /// The date on which the person's requirements for earning a credential were met or completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20645">Credential Completion Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Credential Award End Date
        /// <para>
        /// The date, if any, on which the qualification, achievement, personal or organizational quality, or aspect of an identity expires or requires renewal.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20121">Credential Award End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CredentialAwardEndDate { get; set; }

        /// <summary>
        /// Credential Award Start Date
        /// <para>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20120">Credential Award Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CredentialAwardStartDate { get; set; }

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
        /// Credential Award Evidence URL
        /// <para>
        /// A URL to a page that describes the evidence that the learner met the criteria for attainment of the credential award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20650">Credential Award Evidence URL</a>
        /// </para>
        /// </summary>
        public System.String EvidenceURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid? PersonId { get; set; }

        /// <summary>
        /// Credential Revoked Date
        /// <para>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was revoked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20641">Credential Revoked Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? RevokedDate { get; set; }

        /// <summary>
        /// Credential Revoked Indicator
        /// <para>
        /// Indicates whether the credential has been revoked by the credential provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20732">Credential Revoked Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? RevokedIndicator { get; set; }

        /// <summary>
        /// Credential Revoked Reason
        /// <para>
        /// Published reason for revocation of a credential award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20642">Credential Revoked Reason</a>
        /// </para>
        /// </summary>
        public System.String RevokedReason { get; set; }

    }
}
