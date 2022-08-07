//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialAwardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialAwardModel Interface
     /// </summary>
    public partial interface ICredentialAwardModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialIssuer"/> model
        /// </summary>
        Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        Guid? PersonId { get; set; }

        /// <summary>
        /// Defines the CredentialAward.AdvancedStandingDescription non nullable property
        /// </summary>
        System.String AdvancedStandingDescription { get; set; }

        /// <summary>
        /// Defines the CredentialAward.AdvancedStandingURL non nullable property
        /// </summary>
        System.String AdvancedStandingURL { get; set; }

        /// <summary>
        /// Defines the CredentialAward.ApproverName non nullable property
        /// </summary>
        System.String ApproverName { get; set; }

        /// <summary>
        /// Defines the CredentialAward.CompletionDate nullable property
        /// </summary>
        System.DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Defines the CredentialAward.CredentialAwardEndDate nullable property
        /// </summary>
        System.DateTime? CredentialAwardEndDate { get; set; }

        /// <summary>
        /// Defines the CredentialAward.EvidenceURL non nullable property
        /// </summary>
        System.String EvidenceURL { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RevokedDate nullable property
        /// </summary>
        System.DateTime? RevokedDate { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RevokedIndicator nullable property
        /// </summary>
        System.Boolean? RevokedIndicator { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RevokedReason non nullable property
        /// </summary>
        System.String RevokedReason { get; set; }

        /// <summary>
        /// Defines the CredentialAward.CredentialAwardStartDate nullable property
        /// </summary>
        System.DateTime? CredentialAwardStartDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

    }
}
