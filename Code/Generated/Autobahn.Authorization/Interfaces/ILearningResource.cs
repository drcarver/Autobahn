//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ILearningResource.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ILearningResource Interface
     /// </summary>
    public partial interface ILearningResource : IAutobahnBase
    {
        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String AdaptedFromURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.Boolean? AssistiveTechnologiesCompatibleInd { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String BasedOnUrl { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String ConceptKeyword { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String CopyrightHolderName { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String CopyrightYear { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String Creator { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String LearningResourceAuthorEmail { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String LearningResourceAuthorURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.DateTime? LearningResourceDateModified { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String LearningResourceLicenseURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String LearningResourcePublisherEmail { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String LearningResourcePublisherURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.Int32? PeerRatingSampleSize { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String PublisherName { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceAccessAPITypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceAccessHazardTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceAccessModeTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceAccessRightsUrlId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceAuthorTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceBookFormatTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceControlFlexibilityTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceDigitalMediaSubTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceDigitalMediaTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceEducationalUseId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceIntendedEndUserRoleId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceInteractionModeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceInteractivityTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        Guid? RefLearningResourceTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String SubjectCode { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String SubjectCodeSystem { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String SubjectName { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String TextComplexitySystem { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String TextComplexityValue { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.Decimal? TimeRequired { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.Byte? TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.Byte? TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String Url { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        System.String Version { get; set; }

    }
}
