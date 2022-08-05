//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialDefinition.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefinition
     /// </summary>
    public partial interface ICredentialDefinition : IAutobahnBase
    {
        /// <summary>
        /// Defines the CredentialDefinition.AlternateName non nullable property
        /// </summary>
        System.String AlternateName { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.CredentialNAICSIndustryType non nullable property
        /// </summary>
        System.String CredentialNAICSIndustryType { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.EmploymentNAICSCode non nullable property
        /// </summary>
        System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.ImageUrl non nullable property
        /// </summary>
        System.String ImageUrl { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.JurisdictionRegion non nullable property
        /// </summary>
        System.String JurisdictionRegion { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.JurisdictionRegionException non nullable property
        /// </summary>
        System.String JurisdictionRegionException { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.Keywords non nullable property
        /// </summary>
        System.String Keywords { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.ValidationMethodDescription non nullable property
        /// </summary>
        System.String ValidationMethodDescription { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.Version nullable property
        /// </summary>
        System.Decimal? Version { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.CredentialDefDateEffective nullable property
        /// </summary>
        System.DateTime? CredentialDefDateEffective { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefIntendedPurposeType"/> model
        /// </summary>
        Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefStatusType"/> model
        /// </summary>
        Guid? RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCredentialDefVerificationType"/> model
        /// </summary>
        Guid? RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefONETSOCOccupationType"/> model
        /// </summary>
        Guid? RefONETSOCOccupationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCTDLAudienceLevelType"/> model
        /// </summary>
        Guid? RefCTDLAudienceLevelTypeId { get; set; }

        /// <summary>
        /// Defines the CredentialDefinition.CredentialDefinitionTerminalDegreeIndicator nullable property
        /// </summary>
        System.Boolean? CredentialDefinitionTerminalDegreeIndicator { get; set; }

    }
}
