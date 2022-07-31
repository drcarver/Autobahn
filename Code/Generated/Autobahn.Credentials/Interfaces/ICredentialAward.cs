//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialAward.cs
//**********************************************************

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialAward
     /// </summary>
    public partial Interface ICredentialAward
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialAward"/> model
        /// </summary>
        Guid CredentialAwardId { get; set; }

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
        /// The date, if any, on which the qualification, achievement, personal or organizational quality, or aspect of an identity expires or requires renewal.
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
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
    System.DateTime? CredentialAwardStartDate { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialAward.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
