//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResource Model
     /// </summary>
    public partial class LearningResourceModel : AutobahnBase, Interfaces.ILearningResource
    {
        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String AdaptedFromURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Boolean? AssistiveTechnologiesCompatibleInd { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String BasedOnUrl { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String ConceptKeyword { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String CopyrightHolderName { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String CopyrightYear { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String Creator { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourceAuthorEmail { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourceAuthorURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.DateTime? LearningResourceDateModified { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourceLicenseURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourcePublisherEmail { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourcePublisherURL { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Int32? PeerRatingSampleSize { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String PublisherName { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceAccessAPITypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceAccessHazardTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceAccessModeTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceAccessRightsUrlId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceAuthorTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceBookFormatTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceControlFlexibilityTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaSubTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceEducationalUseId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceIntendedEndUserRoleId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceInteractionModeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceInteractivityTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public Guid? RefLearningResourceTypeId { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String SubjectCode { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String SubjectCodeSystem { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String SubjectName { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String TextComplexitySystem { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String TextComplexityValue { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Decimal? TimeRequired { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Byte? TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Byte? TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String Url { get; set; }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String Version { get; set; }

    }
}
