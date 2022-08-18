//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceModel.cs
//* Name:       Learning Resource Adapted From URL
//* Definition: URL identifier of a learning resource for which this resource is an adaptation.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// URL identifier of a learning resource for which this resource is an adaptation.
     /// </summary>
    public partial class LearningResourceModel : AutobahnBase, Interfaces.ILearningResource
    {
        /// <summary>
        /// Learning Resource Adapted From URL
        /// <para>
        /// URL identifier of a learning resource for which this resource is an adaptation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20367">Learning Resource Adapted From URL</a>
        /// </para>
        /// </summary>
        public System.String AdaptedFromURL { get; set; }

        /// <summary>
        /// Learning Resource Assistive Technologies Compatible Indicator
        /// <para>
        /// Indicates that the learning resource is compatible with assistive technologies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20362">Learning Resource Assistive Technologies Compatible Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? AssistiveTechnologiesCompatibleInd { get; set; }

        /// <summary>
        /// Learning Resource Based on URL
        /// <para>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19923">Learning Resource Based on URL</a>
        /// </para>
        /// </summary>
        public System.String BasedOnUrl { get; set; }

        /// <summary>
        /// Learning Resource Concept Keyword
        /// <para>
        /// The significant topicality of the Learning Resource using free-text keywords and phrases.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20159">Learning Resource Concept Keyword</a>
        /// </para>
        /// </summary>
        public System.String ConceptKeyword { get; set; }

        /// <summary>
        /// Learning Resource Copyright Holder Name
        /// <para>
        /// The name(s) of the person(s) or organization(s) holding the copyright for the Learning Resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20157">Learning Resource Copyright Holder Name</a>
        /// </para>
        /// </summary>
        public System.String CopyrightHolderName { get; set; }

        /// <summary>
        /// Learning Resource Copyright Year
        /// <para>
        /// The copyright year for the Learning Resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20158">Learning Resource Copyright Year</a>
        /// </para>
        /// </summary>
        public System.String CopyrightYear { get; set; }

        /// <summary>
        /// Learning Resource Creator
        /// <para>
        /// The name of a person or organization credited with the creation of the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19918">Learning Resource Creator</a>
        /// </para>
        /// </summary>
        public System.String Creator { get; set; }

        /// <summary>
        /// Learning Resource Date Created
        /// <para>
        /// The date on which the resource was created.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19916">Learning Resource Date Created</a>
        /// </para>
        /// </summary>
        public System.DateTime? DateCreated { get; set; }

        /// <summary>
        /// Learning Resource Author Email
        /// <para>
        /// An email address for the author of the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20544">Learning Resource Author Email</a>
        /// </para>
        /// </summary>
        public System.String LearningResourceAuthorEmail { get; set; }

        /// <summary>
        /// Learning Resource Author URL
        /// <para>
        /// A Uniform Resource Locator (URL) attributed to the author of a learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20541">Learning Resource Author URL</a>
        /// </para>
        /// </summary>
        public System.String LearningResourceAuthorURL { get; set; }

        /// <summary>
        /// Learning Resource Date Modified
        /// <para>
        /// The most recent date that the learning resource was updated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20542">Learning Resource Date Modified</a>
        /// </para>
        /// </summary>
        public System.DateTime? LearningResourceDateModified { get; set; }

        /// <summary>
        /// Learning Resource License URL
        /// <para>
        /// The URL where the owner specifies permissions for using the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19922">Learning Resource License URL</a>
        /// </para>
        /// </summary>
        public System.String LearningResourceLicenseURL { get; set; }

        /// <summary>
        /// Learning Resource Publisher Email
        /// <para>
        /// An email address for the publisher of the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20545">Learning Resource Publisher Email</a>
        /// </para>
        /// </summary>
        public System.String LearningResourcePublisherEmail { get; set; }

        /// <summary>
        /// Learning Resource Publisher URL
        /// <para>
        /// A Uniform Resource Locator (URL) attributed to the publisher of a learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20547">Learning Resource Publisher URL</a>
        /// </para>
        /// </summary>
        public System.String LearningResourcePublisherURL { get; set; }

        /// <summary>
        /// Learning Resource Peer Rating Sample Size
        /// <para>
        /// The sample size of a peer rating value. Only used when the Peer Rating Value is collected in aggregate as an average of multiple atomic/individual ratings.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20369">Learning Resource Peer Rating Sample Size</a>
        /// </para>
        /// </summary>
        public System.Int32? PeerRatingSampleSize { get; set; }

        /// <summary>
        /// Learning Resource Published Date
        /// <para>
        /// The published date of an educational resource, such as instructional media, an assessment form, or section of an assessment form.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20135">Learning Resource Published Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Learning Resource Publisher Name
        /// <para>
        /// The name of the organization credited with publishing the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19919">Learning Resource Publisher Name</a>
        /// </para>
        /// </summary>
        public System.String PublisherName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessRightsUrl"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessRightsUrlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAuthorType"/> model
        /// </summary>
        public Guid? RefLearningResourceAuthorTypeId { get; set; }

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
        /// Reference to an optional instance of the <see cref="RefLearningResourceEducationalUse"/> model
        /// </summary>
        public Guid? RefLearningResourceEducationalUseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceIntendedEndUserRole"/> model
        /// </summary>
        public Guid? RefLearningResourceIntendedEndUserRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractionMode"/> model
        /// </summary>
        public Guid? RefLearningResourceInteractionModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractivityType"/> model
        /// </summary>
        public Guid? RefLearningResourceInteractivityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceType"/> model
        /// </summary>
        public Guid? RefLearningResourceTypeId { get; set; }

        /// <summary>
        /// Learning Resource Subject Code
        /// <para>
        /// The code used to identify the organization of subject matter and related learning experiences addressed by the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19914">Learning Resource Subject Code</a>
        /// </para>
        /// </summary>
        public System.String SubjectCode { get; set; }

        /// <summary>
        /// Learning Resource Subject Code System
        /// <para>
        /// The system that is used to identify the organization of subject matter and related learning experiences addressed by the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19915">Learning Resource Subject Code System</a>
        /// </para>
        /// </summary>
        public System.String SubjectCodeSystem { get; set; }

        /// <summary>
        /// Learning Resource Subject Name
        /// <para>
        /// The descriptive name for the subject of the content for the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19913">Learning Resource Subject Name</a>
        /// </para>
        /// </summary>
        public System.String SubjectName { get; set; }

        /// <summary>
        /// Learning Resource Text Complexity System
        /// <para>
        /// The scaling system used to specify the text complexity of an Learning Resource
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19931">Learning Resource Text Complexity System</a>
        /// </para>
        /// </summary>
        public System.String TextComplexitySystem { get; set; }

        /// <summary>
        /// Learning Resource Text Complexity Value
        /// <para>
        /// The complexity of the text using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19930">Learning Resource Text Complexity Value</a>
        /// </para>
        /// </summary>
        public System.String TextComplexityValue { get; set; }

        /// <summary>
        /// Learning Resource Time Required
        /// <para>
        /// The approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19925">Learning Resource Time Required</a>
        /// </para>
        /// </summary>
        public System.Decimal? TimeRequired { get; set; }

        /// <summary>
        /// Learning Resource Title
        /// <para>
        /// The title of the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19912">Learning Resource Title</a>
        /// </para>
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Learning Resource Typical Age Range Maximum
        /// <para>
        /// The maximum for the typical range of ages of the content's intended end user.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19927">Learning Resource Typical Age Range Maximum</a>
        /// </para>
        /// </summary>
        public System.Byte? TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// Learning Resource Typical Age Range Minimum
        /// <para>
        /// The minimum for the typical range of ages of the content's intended end user.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19926">Learning Resource Typical Age Range Minimum</a>
        /// </para>
        /// </summary>
        public System.Byte? TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// Learning Resource URL
        /// <para>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19911">Learning Resource URL</a>
        /// </para>
        /// </summary>
        public System.String Url { get; set; }

        /// <summary>
        /// Learning Resource Version
        /// <para>
        /// Defines the version of the learning resource as defined by the publisher.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20182">Learning Resource Version</a>
        /// </para>
        /// </summary>
        public System.String Version { get; set; }

    }
}
