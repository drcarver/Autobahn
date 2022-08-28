//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialOffered.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Credentials
{
     /// <summary>
     /// The ICredentialOffered Interface
     /// </summary>
    public partial interface ICredentialOffered : IAutobahnBase
    {
        #region ICredentialOffered
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
        /// </summary>
        Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// Credential Offered End Date
        /// <para>
        /// The last date a credential was offered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20893">Credential Offered End Date</a>
        /// </para>
        /// </summary>
        DateTime? CredentialOfferedEndDate { get; set; }

        /// <summary>
        /// Credential Offered Start Date
        /// <para>
        /// The first date a credential was offered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20892">Credential Offered Start Date</a>
        /// </para>
        /// </summary>
        DateTime? CredentialOfferedStartDate { get; set; }

        #endregion
    }
}