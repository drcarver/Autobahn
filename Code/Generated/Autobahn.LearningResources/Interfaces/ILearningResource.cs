//**********************************************************
//* DomainName: Autobahn.LearningResources
//* FileName:   ILearningResource.cs
//**********************************************************

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResource
     /// </summary>
    public partial interface ILearningResource
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid LearningResourceId { get; set; }

        /// <summary>
        /// Defines the LearningResource.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the LearningResource.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the LearningResource.Url non nullable property
        /// </summary>
        System.String Url { get; set; }

        /// <summary>
        /// Defines the LearningResource.ConceptKeyword non nullable property
        /// </summary>
        System.String ConceptKeyword { get; set; }

        /// <summary>
        /// Defines the LearningResource.SubjectName non nullable property
        /// </summary>
        System.String SubjectName { get; set; }

        /// <summary>
        /// Defines the LearningResource.SubjectCode non nullable property
        /// </summary>
        System.String SubjectCode { get; set; }

        /// <summary>
        /// Defines the LearningResource.SubjectCodeSystem non nullable property
        /// </summary>
        System.String SubjectCodeSystem { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceType"/> model
        /// </summary>
        Guid? RefLearningResourceTypeId { get; set; }

        /// <summary>
        /// Defines the LearningResource.DateCreated nullable property
        /// </summary>
        System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// Defines the LearningResource.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

        /// <summary>
        /// Defines the LearningResource.Creator non nullable property
        /// </summary>
        System.String Creator { get; set; }

        /// <summary>
        /// Defines the LearningResource.PublisherName non nullable property
        /// </summary>
        System.String PublisherName { get; set; }

        /// <summary>
        /// Defines the LearningResource.PublishedDate nullable property
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the LearningResource.CopyrightHolderName non nullable property
        /// </summary>
        System.String CopyrightHolderName { get; set; }

        /// <summary>
        /// Defines the LearningResource.CopyrightYear non nullable property
        /// </summary>
        System.String CopyrightYear { get; set; }

        /// <summary>
        /// The URL where the owner specifies permissions for using the resource.
        /// </summary>
    System.String LearningResourceLicenseURL { get; set; }

        /// <summary>
        /// Defines the LearningResource.BasedOnUrl non nullable property
        /// </summary>
        System.String BasedOnUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceIntendedEndUserRole"/> model
        /// </summary>
        Guid? RefLearningResourceIntendedEndUserRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceEducationalUse"/> model
        /// </summary>
        Guid? RefLearningResourceEducationalUseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractivityType"/> model
        /// </summary>
        Guid? RefLearningResourceInteractivityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Defines the LearningResource.TimeRequired nullable property
        /// </summary>
        System.Decimal? TimeRequired { get; set; }

        /// <summary>
        /// Defines the LearningResource.TypicalAgeRangeMinimum nullable property
        /// </summary>
        System.Byte? TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// Defines the LearningResource.TypicalAgeRangeMaximum nullable property
        /// </summary>
        System.Byte? TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// Defines the LearningResource.TextComplexityValue non nullable property
        /// </summary>
        System.String TextComplexityValue { get; set; }

        /// <summary>
        /// Defines the LearningResource.TextComplexitySystem non nullable property
        /// </summary>
        System.String TextComplexitySystem { get; set; }

        /// <summary>
        /// Defines the LearningResource.AdaptedFromURL non nullable property
        /// </summary>
        System.String AdaptedFromURL { get; set; }

        /// <summary>
        /// Defines the LearningResource.AssistiveTechnologiesCompatibleInd nullable property
        /// </summary>
        System.Boolean? AssistiveTechnologiesCompatibleInd { get; set; }

        /// <summary>
        /// Defines the LearningResource.PeerRatingSampleSize nullable property
        /// </summary>
        System.Int32? PeerRatingSampleSize { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessAPIType"/> model
        /// </summary>
        Guid? RefLearningResourceAccessAPITypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessHazardType"/> model
        /// </summary>
        Guid? RefLearningResourceAccessHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessModeType"/> model
        /// </summary>
        Guid? RefLearningResourceAccessModeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceBookFormatType"/> model
        /// </summary>
        Guid? RefLearningResourceBookFormatTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceControlFlexibilityType"/> model
        /// </summary>
        Guid? RefLearningResourceControlFlexibilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaSubType"/> model
        /// </summary>
        Guid? RefLearningResourceDigitalMediaSubTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaType"/> model
        /// </summary>
        Guid? RefLearningResourceDigitalMediaTypeId { get; set; }

        /// <summary>
        /// An email address for the author of the learning resource.
        /// </summary>
    System.String LearningResourceAuthorEmail { get; set; }

        /// <summary>
        /// A Uniform Resource Locator (URL) attributed to the author of a learning resource.
        /// </summary>
    System.String LearningResourceAuthorURL { get; set; }

        /// <summary>
        /// The most recent date that the learning resource was updated.
        /// </summary>
    System.DateTime? LearningResourceDateModified { get; set; }

        /// <summary>
        /// An email address for the publisher of the learning resource.
        /// </summary>
    System.String LearningResourcePublisherEmail { get; set; }

        /// <summary>
        /// A Uniform Resource Locator (URL) attributed to the publisher of a learning resource.
        /// </summary>
    System.String LearningResourcePublisherURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessRightsUrl"/> model
        /// </summary>
        Guid? RefLearningResourceAccessRightsUrlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAuthorType"/> model
        /// </summary>
        Guid? RefLearningResourceAuthorTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractionMode"/> model
        /// </summary>
        Guid? RefLearningResourceInteractionModeId { get; set; }

        /// <summary>
        /// Defines the LearningResource.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LearningResource.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

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
