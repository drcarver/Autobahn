//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAward.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAward
     /// </summary>
    public partial class CredentialAward : ICredentialAward
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialAward"/> model
        /// </summary>
        public Guid CredentialAwardId { get; set; }

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
        /// The date, if any, on which the qualification, achievement, personal or organizational quality, or aspect of an identity expires or requires renewal.
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
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
    public System.DateTime? CredentialAwardStartDate { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}