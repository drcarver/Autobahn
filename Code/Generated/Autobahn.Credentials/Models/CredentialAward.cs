//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAward.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAward
     /// </summary>
    public partial class CredentialAward : AutobahnBase, Interfaces.ICredentialAward
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialIssuer"/> model
        /// </summary>
        public Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid? PersonId { get; set; }

        /// <summary>
        /// Defines the CredentialAward.AdvancedStandingDescription non nullable property
        /// </summary>
        public System.String AdvancedStandingDescription { get; set; }

        /// <summary>
        /// Defines the CredentialAward.AdvancedStandingURL non nullable property
        /// </summary>
        public System.String AdvancedStandingURL { get; set; }

        /// <summary>
        /// Defines the CredentialAward.ApproverName non nullable property
        /// </summary>
        public System.String ApproverName { get; set; }

        /// <summary>
        /// Defines the CredentialAward.CompletionDate nullable property
        /// </summary>
        public System.DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Defines the CredentialAward.CredentialAwardEndDate nullable property
        /// </summary>
        public System.DateTime? CredentialAwardEndDate { get; set; }

        /// <summary>
        /// Defines the CredentialAward.EvidenceURL non nullable property
        /// </summary>
        public System.String EvidenceURL { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RevokedDate nullable property
        /// </summary>
        public System.DateTime? RevokedDate { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RevokedIndicator nullable property
        /// </summary>
        public System.Boolean? RevokedIndicator { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RevokedReason non nullable property
        /// </summary>
        public System.String RevokedReason { get; set; }

        /// <summary>
        /// Defines the CredentialAward.CredentialAwardStartDate nullable property
        /// </summary>
        public System.DateTime? CredentialAwardStartDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
