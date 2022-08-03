//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefinition.cs
//**********************************************************

using Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefinition
     /// </summary>
    public partial class CredentialDefinition : ICredentialDefinition
    {
        /// <summary>
        /// Defines the CredentialDefinition.AlternateName non nullable property
        /// </summary>
        public System.String AlternateName { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.CredentialNAICSIndustryType non nullable property
        /// </summary>
        public System.String CredentialNAICSIndustryType { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.EmploymentNAICSCode non nullable property
        /// </summary>
        public System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.ImageUrl non nullable property
        /// </summary>
        public System.String ImageUrl { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.JurisdictionRegion non nullable property
        /// </summary>
        public System.String JurisdictionRegion { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.JurisdictionRegionException non nullable property
        /// </summary>
        public System.String JurisdictionRegionException { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.Keywords non nullable property
        /// </summary>
        public System.String Keywords { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.ValidationMethodDescription non nullable property
        /// </summary>
        public System.String ValidationMethodDescription { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.Version nullable property
        /// </summary>
        public System.Decimal? Version { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.CredentialDefDateEffective nullable property
        /// </summary>
        public System.DateTime? CredentialDefDateEffective { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefIntendedPurposeType"/> model
        /// </summary>
        public Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefStatusType"/> model
        /// </summary>
        public Guid? RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefVerificationType"/> model
        /// </summary>
        public Guid? RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefONETSOCOccupationType"/> model
        /// </summary>
        public Guid? RefONETSOCOccupationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLAudienceLevelType"/> model
        /// </summary>
        public Guid? RefCTDLAudienceLevelTypeId { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.CredentialDefinitionTerminalDegreeIndicator nullable property
        /// </summary>
        public System.Boolean? CredentialDefinitionTerminalDegreeIndicator { get; set; }

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
