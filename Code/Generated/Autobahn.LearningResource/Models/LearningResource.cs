//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResource.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The LearningResource
     /// </summary>
    public partial class LearningResource : AutobahnBase, Interfaces.ILearningResource
    {
        /// <summary>
        /// Defines the LearningResource.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the LearningResource.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the LearningResource.Url non nullable property
        /// </summary>
        public System.String Url { get; set; }

        /// <summary>
        /// Defines the LearningResource.ConceptKeyword non nullable property
        /// </summary>
        public System.String ConceptKeyword { get; set; }

        /// <summary>
        /// Defines the LearningResource.SubjectName non nullable property
        /// </summary>
        public System.String SubjectName { get; set; }

        /// <summary>
        /// Defines the LearningResource.SubjectCode non nullable property
        /// </summary>
        public System.String SubjectCode { get; set; }

        /// <summary>
        /// Defines the LearningResource.SubjectCodeSystem non nullable property
        /// </summary>
        public System.String SubjectCodeSystem { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceType"/> model
        /// </summary>
        public Guid? RefLearningResourceTypeId { get; set; }

        /// <summary>
        /// Defines the LearningResource.DateCreated nullable property
        /// </summary>
        public System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// Defines the LearningResource.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

        /// <summary>
        /// Defines the LearningResource.Creator non nullable property
        /// </summary>
        public System.String Creator { get; set; }

        /// <summary>
        /// Defines the LearningResource.PublisherName non nullable property
        /// </summary>
        public System.String PublisherName { get; set; }

        /// <summary>
        /// Defines the LearningResource.PublishedDate nullable property
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the LearningResource.CopyrightHolderName non nullable property
        /// </summary>
        public System.String CopyrightHolderName { get; set; }

        /// <summary>
        /// Defines the LearningResource.CopyrightYear non nullable property
        /// </summary>
        public System.String CopyrightYear { get; set; }

        /// <summary>
        /// Defines the LearningResource.LearningResourceLicenseURL non nullable property
        /// </summary>
        public System.String LearningResourceLicenseURL { get; set; }

        /// <summary>
        /// Defines the LearningResource.BasedOnUrl non nullable property
        /// </summary>
        public System.String BasedOnUrl { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceIntendedEndUserRole"/> model
        /// </summary>
        public Guid? RefLearningResourceIntendedEndUserRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceEducationalUse"/> model
        /// </summary>
        public Guid? RefLearningResourceEducationalUseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractivityType"/> model
        /// </summary>
        public Guid? RefLearningResourceInteractivityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// Defines the LearningResource.TimeRequired nullable property
        /// </summary>
        public System.Decimal? TimeRequired { get; set; }

        /// <summary>
        /// Defines the LearningResource.TypicalAgeRangeMinimum nullable property
        /// </summary>
        public System.Byte? TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// Defines the LearningResource.TypicalAgeRangeMaximum nullable property
        /// </summary>
        public System.Byte? TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// Defines the LearningResource.TextComplexityValue non nullable property
        /// </summary>
        public System.String TextComplexityValue { get; set; }

        /// <summary>
        /// Defines the LearningResource.TextComplexitySystem non nullable property
        /// </summary>
        public System.String TextComplexitySystem { get; set; }

        /// <summary>
        /// Defines the LearningResource.AdaptedFromURL non nullable property
        /// </summary>
        public System.String AdaptedFromURL { get; set; }

        /// <summary>
        /// Defines the LearningResource.AssistiveTechnologiesCompatibleInd nullable property
        /// </summary>
        public System.Boolean? AssistiveTechnologiesCompatibleInd { get; set; }

        /// <summary>
        /// Defines the LearningResource.PeerRatingSampleSize nullable property
        /// </summary>
        public System.Int32? PeerRatingSampleSize { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessAPIType"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessAPITypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessHazardType"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessHazardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessModeType"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessModeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceBookFormatType"/> model
        /// </summary>
        public Guid? RefLearningResourceBookFormatTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceControlFlexibilityType"/> model
        /// </summary>
        public Guid? RefLearningResourceControlFlexibilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaSubType"/> model
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaSubTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaType"/> model
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaTypeId { get; set; }

        /// <summary>
        /// Defines the LearningResource.LearningResourceAuthorEmail non nullable property
        /// </summary>
        public System.String LearningResourceAuthorEmail { get; set; }

        /// <summary>
        /// Defines the LearningResource.LearningResourceAuthorURL non nullable property
        /// </summary>
        public System.String LearningResourceAuthorURL { get; set; }

        /// <summary>
        /// Defines the LearningResource.LearningResourceDateModified nullable property
        /// </summary>
        public System.DateTime? LearningResourceDateModified { get; set; }

        /// <summary>
        /// Defines the LearningResource.LearningResourcePublisherEmail non nullable property
        /// </summary>
        public System.String LearningResourcePublisherEmail { get; set; }

        /// <summary>
        /// Defines the LearningResource.LearningResourcePublisherURL non nullable property
        /// </summary>
        public System.String LearningResourcePublisherURL { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessRightsUrl"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessRightsUrlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAuthorType"/> model
        /// </summary>
        public Guid? RefLearningResourceAuthorTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractionMode"/> model
        /// </summary>
        public Guid? RefLearningResourceInteractionModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
