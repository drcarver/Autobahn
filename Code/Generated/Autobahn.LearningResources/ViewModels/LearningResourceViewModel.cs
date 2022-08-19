//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceViewModel.cs
//* Name:       Learning Resource Adapted From URL
//* Definition: URL identifier of a learning resource for which this resource is an adaptation.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// URL identifier of a learning resource for which this resource is an adaptation.
     /// </summary>
    public partial class LearningResourceViewModel : ViewModelBase, Interfaces.ILearningResource
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResource";

        // AdaptedFromURL -- (backing property for Learning Resource Adapted From URL)
        private System.String _AdaptedFromURL;

        // AssistiveTechnologiesCompatibleInd -- (backing property for Learning Resource Assistive Technologies Compatible Indicator)
        private System.Boolean? _AssistiveTechnologiesCompatibleInd;

        // BasedOnUrl -- (backing property for Learning Resource Based on URL)
        private System.String _BasedOnUrl;

        // ConceptKeyword -- (backing property for Learning Resource Concept Keyword)
        private System.String _ConceptKeyword;

        // CopyrightHolderName -- (backing property for Learning Resource Copyright Holder Name)
        private System.String _CopyrightHolderName;

        // CopyrightYear -- (backing property for Learning Resource Copyright Year)
        private System.String _CopyrightYear;

        // Creator -- (backing property for Learning Resource Creator)
        private System.String _Creator;

        // DateCreated -- (backing property for Learning Resource Date Created)
        private System.DateTime? _DateCreated;

        // LearningResourceAuthorEmail -- (backing property for Learning Resource Author Email)
        private System.String _LearningResourceAuthorEmail;

        // LearningResourceAuthorURL -- (backing property for Learning Resource Author URL)
        private System.String _LearningResourceAuthorURL;

        // LearningResourceDateModified -- (backing property for Learning Resource Date Modified)
        private System.DateTime? _LearningResourceDateModified;

        // LearningResourceLicenseURL -- (backing property for Learning Resource License URL)
        private System.String _LearningResourceLicenseURL;

        // LearningResourcePublisherEmail -- (backing property for Learning Resource Publisher Email)
        private System.String _LearningResourcePublisherEmail;

        // LearningResourcePublisherURL -- (backing property for Learning Resource Publisher URL)
        private System.String _LearningResourcePublisherURL;

        // PeerRatingSampleSize -- (backing property for Learning Resource Peer Rating Sample Size)
        private System.Int32? _PeerRatingSampleSize;

        // PublishedDate -- (backing property for Learning Resource Published Date)
        private System.DateTime? _PublishedDate;

        // PublisherName -- (backing property for Learning Resource Publisher Name)
        private System.String _PublisherName;

        // RefLanguageId -- (backing property for Learning Resource Language)
        private Guid? _RefLanguageId;

        // RefLearningResourceAccessAPITypeId -- (backing property for Learning Resource Access API Type)
        private Guid? _RefLearningResourceAccessAPITypeId;

        // RefLearningResourceAccessHazardTypeId -- (backing property for Learning Resource Access Hazard Type)
        private Guid? _RefLearningResourceAccessHazardTypeId;

        // RefLearningResourceAccessModeTypeId -- (backing property for Learning Resource Access Mode Type)
        private Guid? _RefLearningResourceAccessModeTypeId;

        // RefLearningResourceAccessRightsUrlId -- (backing property for Learning Resource Access Rights URL)
        private Guid? _RefLearningResourceAccessRightsUrlId;

        // RefLearningResourceAuthorTypeId -- (backing property for Learning Resource Author Type)
        private Guid? _RefLearningResourceAuthorTypeId;

        // RefLearningResourceBookFormatTypeId -- (backing property for Learning Resource Book Format Type)
        private Guid? _RefLearningResourceBookFormatTypeId;

        // RefLearningResourceControlFlexibilityTypeId -- (backing property for Learning Resource Control Flexibility Type)
        private Guid? _RefLearningResourceControlFlexibilityTypeId;

        // RefLearningResourceDigitalMediaSubTypeId -- (backing property for Learning Resource Digital Media Sub Type)
        private Guid? _RefLearningResourceDigitalMediaSubTypeId;

        // RefLearningResourceDigitalMediaTypeId -- (backing property for Learning Resource Digital Media Type)
        private Guid? _RefLearningResourceDigitalMediaTypeId;

        // RefLearningResourceEducationalUseId -- (backing property for Learning Resource Educational Use)
        private Guid? _RefLearningResourceEducationalUseId;

        // RefLearningResourceIntendedEndUserRoleId -- (backing property for Learning Resource Intended End User Role)
        private Guid? _RefLearningResourceIntendedEndUserRoleId;

        // RefLearningResourceInteractionModeId -- (backing property for Learning Resource Interaction Mode)
        private Guid? _RefLearningResourceInteractionModeId;

        // RefLearningResourceInteractivityTypeId -- (backing property for Learning Resource Interactivity Type)
        private Guid? _RefLearningResourceInteractivityTypeId;

        // RefLearningResourceTypeId -- (backing property for Learning Resource Type)
        private Guid? _RefLearningResourceTypeId;

        // SubjectCode -- (backing property for Learning Resource Subject Code)
        private System.String _SubjectCode;

        // SubjectCodeSystem -- (backing property for Learning Resource Subject Code System)
        private System.String _SubjectCodeSystem;

        // SubjectName -- (backing property for Learning Resource Subject Name)
        private System.String _SubjectName;

        // TextComplexitySystem -- (backing property for Learning Resource Text Complexity System)
        private System.String _TextComplexitySystem;

        // TextComplexityValue -- (backing property for Learning Resource Text Complexity Value)
        private System.String _TextComplexityValue;

        // TimeRequired -- (backing property for Learning Resource Time Required)
        private System.Decimal? _TimeRequired;

        // Title -- (backing property for Learning Resource Title)
        private System.String _Title;

        // TypicalAgeRangeMaximum -- (backing property for Learning Resource Typical Age Range Maximum)
        private System.Byte? _TypicalAgeRangeMaximum;

        // TypicalAgeRangeMinimum -- (backing property for Learning Resource Typical Age Range Minimum)
        private System.Byte? _TypicalAgeRangeMinimum;

        // Url -- (backing property for Learning Resource URL)
        private System.String _Url;

        // Version -- (backing property for Learning Resource Version)
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Learning Resource Adapted From URL
        /// <para>
        /// URL identifier of a learning resource for which this resource is an adaptation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20367">Learning Resource Adapted From URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AdaptedFromURL { get => _AdaptedFromURL; set => SetProperty(ref _AdaptedFromURL, value); }

        /// <summary>
        /// Learning Resource Assistive Technologies Compatible Indicator
        /// <para>
        /// Indicates that the learning resource is compatible with assistive technologies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20362">Learning Resource Assistive Technologies Compatible Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AssistiveTechnologiesCompatibleInd { get => _AssistiveTechnologiesCompatibleInd; set => SetProperty(ref _AssistiveTechnologiesCompatibleInd, value); }

        /// <summary>
        /// Learning Resource Based on URL
        /// <para>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19923">Learning Resource Based on URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BasedOnUrl { get => _BasedOnUrl; set => SetProperty(ref _BasedOnUrl, value); }

        /// <summary>
        /// Learning Resource Concept Keyword
        /// <para>
        /// The significant topicality of the Learning Resource using free-text keywords and phrases.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20159">Learning Resource Concept Keyword</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ConceptKeyword { get => _ConceptKeyword; set => SetProperty(ref _ConceptKeyword, value); }

        /// <summary>
        /// Learning Resource Copyright Holder Name
        /// <para>
        /// The name(s) of the person(s) or organization(s) holding the copyright for the Learning Resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20157">Learning Resource Copyright Holder Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CopyrightHolderName { get => _CopyrightHolderName; set => SetProperty(ref _CopyrightHolderName, value); }

        /// <summary>
        /// Learning Resource Copyright Year
        /// <para>
        /// The copyright year for the Learning Resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20158">Learning Resource Copyright Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CopyrightYear { get => _CopyrightYear; set => SetProperty(ref _CopyrightYear, value); }

        /// <summary>
        /// Learning Resource Creator
        /// <para>
        /// The name of a person or organization credited with the creation of the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19918">Learning Resource Creator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Creator { get => _Creator; set => SetProperty(ref _Creator, value); }

        /// <summary>
        /// Learning Resource Date Created
        /// <para>
        /// The date on which the resource was created.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19916">Learning Resource Date Created</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DateCreated { get => _DateCreated; set => SetProperty(ref _DateCreated, value); }

        /// <summary>
        /// Learning Resource Author Email
        /// <para>
        /// An email address for the author of the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20544">Learning Resource Author Email</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearningResourceAuthorEmail { get => _LearningResourceAuthorEmail; set => SetProperty(ref _LearningResourceAuthorEmail, value); }

        /// <summary>
        /// Learning Resource Author URL
        /// <para>
        /// A Uniform Resource Locator (URL) attributed to the author of a learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20541">Learning Resource Author URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearningResourceAuthorURL { get => _LearningResourceAuthorURL; set => SetProperty(ref _LearningResourceAuthorURL, value); }

        /// <summary>
        /// Learning Resource Date Modified
        /// <para>
        /// The most recent date that the learning resource was updated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20542">Learning Resource Date Modified</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? LearningResourceDateModified { get => _LearningResourceDateModified; set => SetProperty(ref _LearningResourceDateModified, value); }

        /// <summary>
        /// Learning Resource License URL
        /// <para>
        /// The URL where the owner specifies permissions for using the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19922">Learning Resource License URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearningResourceLicenseURL { get => _LearningResourceLicenseURL; set => SetProperty(ref _LearningResourceLicenseURL, value); }

        /// <summary>
        /// Learning Resource Publisher Email
        /// <para>
        /// An email address for the publisher of the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20545">Learning Resource Publisher Email</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearningResourcePublisherEmail { get => _LearningResourcePublisherEmail; set => SetProperty(ref _LearningResourcePublisherEmail, value); }

        /// <summary>
        /// Learning Resource Publisher URL
        /// <para>
        /// A Uniform Resource Locator (URL) attributed to the publisher of a learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20547">Learning Resource Publisher URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearningResourcePublisherURL { get => _LearningResourcePublisherURL; set => SetProperty(ref _LearningResourcePublisherURL, value); }

        /// <summary>
        /// Learning Resource Peer Rating Sample Size
        /// <para>
        /// The sample size of a peer rating value. Only used when the Peer Rating Value is collected in aggregate as an average of multiple atomic/individual ratings.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20369">Learning Resource Peer Rating Sample Size</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? PeerRatingSampleSize { get => _PeerRatingSampleSize; set => SetProperty(ref _PeerRatingSampleSize, value); }

        /// <summary>
        /// Learning Resource Published Date
        /// <para>
        /// The published date of an educational resource, such as instructional media, an assessment form, or section of an assessment form.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20135">Learning Resource Published Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// Learning Resource Publisher Name
        /// <para>
        /// The name of the organization credited with publishing the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19919">Learning Resource Publisher Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PublisherName { get => _PublisherName; set => SetProperty(ref _PublisherName, value); }

        /// <summary>
        /// Learning Resource Language
        /// <para>
        /// The primary language of the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19920">Learning Resource Language</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Learning Resource Access API Type
        /// <para>
        /// Indicates that the learning resource is compatible with the referenced accessibility application programming interface (API).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20358">Learning Resource Access API Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceAccessAPITypeId { get => _RefLearningResourceAccessAPITypeId; set => SetProperty(ref _RefLearningResourceAccessAPITypeId, value); }

        /// <summary>
        /// Learning Resource Access Hazard Type
        /// <para>
        /// A characteristic of the described learning resource that is physiologically dangerous to some users.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20359">Learning Resource Access Hazard Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceAccessHazardTypeId { get => _RefLearningResourceAccessHazardTypeId; set => SetProperty(ref _RefLearningResourceAccessHazardTypeId, value); }

        /// <summary>
        /// Learning Resource Access Mode Type
        /// <para>
        /// An access mode through which the intellectual content of a described learning resource or adaptation is communicated; if adaptations for the resource are known, the access modes of those adaptations are not included.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20360">Learning Resource Access Mode Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceAccessModeTypeId { get => _RefLearningResourceAccessModeTypeId; set => SetProperty(ref _RefLearningResourceAccessModeTypeId, value); }

        /// <summary>
        /// Learning Resource Access Rights URL
        /// <para>
        /// A Uniform Resource Locator (URL) that identifies the conditions that govern the user's ability to access a learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20537">Learning Resource Access Rights URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceAccessRightsUrlId { get => _RefLearningResourceAccessRightsUrlId; set => SetProperty(ref _RefLearningResourceAccessRightsUrlId, value); }

        /// <summary>
        /// Learning Resource Author Type
        /// <para>
        /// The type of entity, organization or person, that authored the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20540">Learning Resource Author Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceAuthorTypeId { get => _RefLearningResourceAuthorTypeId; set => SetProperty(ref _RefLearningResourceAuthorTypeId, value); }

        /// <summary>
        /// Learning Resource Book Format Type
        /// <para>
        /// Specifies the format for a learning resource that is a book.  Other options may be considered for inclusion in the option set.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20363">Learning Resource Book Format Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceBookFormatTypeId { get => _RefLearningResourceBookFormatTypeId; set => SetProperty(ref _RefLearningResourceBookFormatTypeId, value); }

        /// <summary>
        /// Learning Resource Control Flexibility Type
        /// <para>
        /// Identifies a single input method that is sufficient to control the described learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20364">Learning Resource Control Flexibility Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceControlFlexibilityTypeId { get => _RefLearningResourceControlFlexibilityTypeId; set => SetProperty(ref _RefLearningResourceControlFlexibilityTypeId, value); }

        /// <summary>
        /// Learning Resource Digital Media Sub Type
        /// <para>
        /// The media or file subtype of the digital resource being based on the Media Types and Subtypes, formerly known as MIME types, defined by the Internet Assigned Numbers Authority (IANA).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20365">Learning Resource Digital Media Sub Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaSubTypeId { get => _RefLearningResourceDigitalMediaSubTypeId; set => SetProperty(ref _RefLearningResourceDigitalMediaSubTypeId, value); }

        /// <summary>
        /// Learning Resource Digital Media Type
        /// <para>
        /// The media or file type of the digital resource being based on the media types defined by the Internet Assigned Numbers Authority (AINA) at http://www.iana.org/assignments/media-types.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20366">Learning Resource Digital Media Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaTypeId { get => _RefLearningResourceDigitalMediaTypeId; set => SetProperty(ref _RefLearningResourceDigitalMediaTypeId, value); }

        /// <summary>
        /// Learning Resource Educational Use
        /// <para>
        /// The purpose of the work in the context of education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20005">Learning Resource Educational Use</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceEducationalUseId { get => _RefLearningResourceEducationalUseId; set => SetProperty(ref _RefLearningResourceEducationalUseId, value); }

        /// <summary>
        /// Learning Resource Intended End User Role
        /// <para>
        /// The individual or group for which the resource was produced.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19924">Learning Resource Intended End User Role</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceIntendedEndUserRoleId { get => _RefLearningResourceIntendedEndUserRoleId; set => SetProperty(ref _RefLearningResourceIntendedEndUserRoleId, value); }

        /// <summary>
        /// Learning Resource Interaction Mode
        /// <para>
        /// The primary type of interaction, synchronous or asynchronous, defined for the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20543">Learning Resource Interaction Mode</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceInteractionModeId { get => _RefLearningResourceInteractionModeId; set => SetProperty(ref _RefLearningResourceInteractionModeId, value); }

        /// <summary>
        /// Learning Resource Interactivity Type
        /// <para>
        /// The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19928">Learning Resource Interactivity Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceInteractivityTypeId { get => _RefLearningResourceInteractivityTypeId; set => SetProperty(ref _RefLearningResourceInteractivityTypeId, value); }

        /// <summary>
        /// Learning Resource Type
        /// <para>
        /// The predominate type or kind characterizing the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19929">Learning Resource Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearningResourceTypeId { get => _RefLearningResourceTypeId; set => SetProperty(ref _RefLearningResourceTypeId, value); }

        /// <summary>
        /// Learning Resource Subject Code
        /// <para>
        /// The code used to identify the organization of subject matter and related learning experiences addressed by the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19914">Learning Resource Subject Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SubjectCode { get => _SubjectCode; set => SetProperty(ref _SubjectCode, value); }

        /// <summary>
        /// Learning Resource Subject Code System
        /// <para>
        /// The system that is used to identify the organization of subject matter and related learning experiences addressed by the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19915">Learning Resource Subject Code System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SubjectCodeSystem { get => _SubjectCodeSystem; set => SetProperty(ref _SubjectCodeSystem, value); }

        /// <summary>
        /// Learning Resource Subject Name
        /// <para>
        /// The descriptive name for the subject of the content for the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19913">Learning Resource Subject Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SubjectName { get => _SubjectName; set => SetProperty(ref _SubjectName, value); }

        /// <summary>
        /// Learning Resource Text Complexity System
        /// <para>
        /// The scaling system used to specify the text complexity of an Learning Resource
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19931">Learning Resource Text Complexity System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String TextComplexitySystem { get => _TextComplexitySystem; set => SetProperty(ref _TextComplexitySystem, value); }

        /// <summary>
        /// Learning Resource Text Complexity Value
        /// <para>
        /// The complexity of the text using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19930">Learning Resource Text Complexity Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String TextComplexityValue { get => _TextComplexityValue; set => SetProperty(ref _TextComplexityValue, value); }

        /// <summary>
        /// Learning Resource Time Required
        /// <para>
        /// The approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19925">Learning Resource Time Required</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? TimeRequired { get => _TimeRequired; set => SetProperty(ref _TimeRequired, value); }

        /// <summary>
        /// Learning Resource Title
        /// <para>
        /// The title of the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19912">Learning Resource Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// Learning Resource Typical Age Range Maximum
        /// <para>
        /// The maximum for the typical range of ages of the content's intended end user.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19927">Learning Resource Typical Age Range Maximum</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Byte? TypicalAgeRangeMaximum { get => _TypicalAgeRangeMaximum; set => SetProperty(ref _TypicalAgeRangeMaximum, value); }

        /// <summary>
        /// Learning Resource Typical Age Range Minimum
        /// <para>
        /// The minimum for the typical range of ages of the content's intended end user.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19926">Learning Resource Typical Age Range Minimum</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Byte? TypicalAgeRangeMinimum { get => _TypicalAgeRangeMinimum; set => SetProperty(ref _TypicalAgeRangeMinimum, value); }

        /// <summary>
        /// Learning Resource URL
        /// <para>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19911">Learning Resource URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Url { get => _Url; set => SetProperty(ref _Url, value); }

        /// <summary>
        /// Learning Resource Version
        /// <para>
        /// Defines the version of the learning resource as defined by the publisher.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20182">Learning Resource Version</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptedFromURL = model.AdaptedFromURL; // Learning Resource Adapted From URL
            AssistiveTechnologiesCompatibleInd = model.AssistiveTechnologiesCompatibleInd; // Learning Resource Assistive Technologies Compatible Indicator
            BasedOnUrl = model.BasedOnUrl; // Learning Resource Based on URL
            ConceptKeyword = model.ConceptKeyword; // Learning Resource Concept Keyword
            CopyrightHolderName = model.CopyrightHolderName; // Learning Resource Copyright Holder Name
            CopyrightYear = model.CopyrightYear; // Learning Resource Copyright Year
            Creator = model.Creator; // Learning Resource Creator
            DateCreated = model.DateCreated; // Learning Resource Date Created
            LearningResourceAuthorEmail = model.LearningResourceAuthorEmail; // Learning Resource Author Email
            LearningResourceAuthorURL = model.LearningResourceAuthorURL; // Learning Resource Author URL
            LearningResourceDateModified = model.LearningResourceDateModified; // Learning Resource Date Modified
            LearningResourceLicenseURL = model.LearningResourceLicenseURL; // Learning Resource License URL
            LearningResourcePublisherEmail = model.LearningResourcePublisherEmail; // Learning Resource Publisher Email
            LearningResourcePublisherURL = model.LearningResourcePublisherURL; // Learning Resource Publisher URL
            PeerRatingSampleSize = model.PeerRatingSampleSize; // Learning Resource Peer Rating Sample Size
            PublishedDate = model.PublishedDate; // Learning Resource Published Date
            PublisherName = model.PublisherName; // Learning Resource Publisher Name
            RefLanguageId = model.RefLanguageId; // Learning Resource Language
            RefLearningResourceAccessAPITypeId = model.RefLearningResourceAccessAPITypeId; // Learning Resource Access API Type
            RefLearningResourceAccessHazardTypeId = model.RefLearningResourceAccessHazardTypeId; // Learning Resource Access Hazard Type
            RefLearningResourceAccessModeTypeId = model.RefLearningResourceAccessModeTypeId; // Learning Resource Access Mode Type
            RefLearningResourceAccessRightsUrlId = model.RefLearningResourceAccessRightsUrlId; // Learning Resource Access Rights URL
            RefLearningResourceAuthorTypeId = model.RefLearningResourceAuthorTypeId; // Learning Resource Author Type
            RefLearningResourceBookFormatTypeId = model.RefLearningResourceBookFormatTypeId; // Learning Resource Book Format Type
            RefLearningResourceControlFlexibilityTypeId = model.RefLearningResourceControlFlexibilityTypeId; // Learning Resource Control Flexibility Type
            RefLearningResourceDigitalMediaSubTypeId = model.RefLearningResourceDigitalMediaSubTypeId; // Learning Resource Digital Media Sub Type
            RefLearningResourceDigitalMediaTypeId = model.RefLearningResourceDigitalMediaTypeId; // Learning Resource Digital Media Type
            RefLearningResourceEducationalUseId = model.RefLearningResourceEducationalUseId; // Learning Resource Educational Use
            RefLearningResourceIntendedEndUserRoleId = model.RefLearningResourceIntendedEndUserRoleId; // Learning Resource Intended End User Role
            RefLearningResourceInteractionModeId = model.RefLearningResourceInteractionModeId; // Learning Resource Interaction Mode
            RefLearningResourceInteractivityTypeId = model.RefLearningResourceInteractivityTypeId; // Learning Resource Interactivity Type
            RefLearningResourceTypeId = model.RefLearningResourceTypeId; // Learning Resource Type
            SubjectCode = model.SubjectCode; // Learning Resource Subject Code
            SubjectCodeSystem = model.SubjectCodeSystem; // Learning Resource Subject Code System
            SubjectName = model.SubjectName; // Learning Resource Subject Name
            TextComplexitySystem = model.TextComplexitySystem; // Learning Resource Text Complexity System
            TextComplexityValue = model.TextComplexityValue; // Learning Resource Text Complexity Value
            TimeRequired = model.TimeRequired; // Learning Resource Time Required
            Title = model.Title; // Learning Resource Title
            TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum; // Learning Resource Typical Age Range Maximum
            TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum; // Learning Resource Typical Age Range Minimum
            Url = model.Url; // Learning Resource URL
            Version = model.Version; // Learning Resource Version
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLearningResourceAccessAPIType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAccessAPITypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("461f7cf5-7fe7-4d33-ae14-c3084b2e0f57"), Code="AndroidAccessibility", Description="Android Accessibility", Definition="The learning resource is compatible with Android Accessibility.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("8522e912-bf98-4a84-bdac-43fe12552793"), Code="ARIA", Description="ARIA", Definition="The learning resource is compatible with ARIA for accessibility.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6b830f1-0314-4147-92a5-63b1e1eb2b26"), Code="ATK", Description="ATK", Definition="The learning resource is compatible with ATK for accessibility.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("6502b387-1ffd-4bb7-8f51-9c6eb07d61b7"), Code="AT-SPI", Description="AT-SPI", Definition="The learning resource is compatible with AT-SPI for accessibility.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("88c90313-7e53-4372-a51c-0bb6c6acdc32"), Code="BlackberryAccessibility", Description="Blackberry Accessibility", Definition="The learning resource is compatible with Blackberry Accessibility.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("d0386f4e-20e1-49e0-aff7-61be2a228816"), Code="iAccessible2", Description="I Accessible2", Definition="The learning resource is compatible with I Accessible2.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("1458ff8a-3c1a-4fdd-9667-92248e1c97df"), Code="iOSAccessibility", Description="iOS Accessibility", Definition="The learning resource is compatible with iOS Accessibility.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("d3333cfe-ed1f-42ef-a8b1-89d272ecb5dd"), Code="JavaAccessibility", Description="Java Accessibility", Definition="The learning resource is compatible with Java Accessibility.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("d3f9b508-23cb-42ca-b110-f4c3843d6ad7"), Code="MacOSXAccessibility", Description="Mac OSX Accessibility", Definition="The learning resource is compatible with Mac OSX Accessibility.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("fe14a95b-5dc4-42bf-b486-dbb07bf5db97"), Code="MSAA", Description="MSAA", Definition="The learning resource is compatible with MSAA.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("7933f91a-d802-4f19-be53-ca2fb9c8d163"), Code="UIAutomation", Description="UI Automation", Definition="The learning resource is compatible with the UI Automation.", SortOrder=Convert.ToDecimal("22.00") },
        };
        #endregion

        #region RefLearningResourceAccessHazardType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAccessHazardTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8aebcfcb-6887-4ade-bad3-ca045449add5"), Code="Flashing", Description="Flashing", Definition="Flashing is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d7135d6-2958-4fe0-b156-e6e5efc53a1c"), Code="MotionSimulation", Description="Motion simulation", Definition="Motion simulation is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("aa09f17d-83f2-4d1f-a5a4-7f38d8b6676c"), Code="Sound", Description="Sound", Definition="Sound is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefLearningResourceAccessModeType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAccessModeTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("72d2ff44-e6e3-4400-b409-bcf04b4f9a1e"), Code="auditory", Description="Auditory", Definition="Auditory is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("479e3d33-e555-4756-b615-409d83d998cc"), Code="colorDependent", Description="Color Dependent", Definition="Color Dependent is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("6cb4d6ac-c6a8-4416-bbbf-dd605685f6c9"), Code="tactile", Description="Tactile", Definition="Tactile is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("c8d4a81f-7a5a-42de-810c-81a50127ac98"), Code="textOnImage", Description="Text On Image", Definition="Text On Image is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("d0fcc396-75d5-43b0-aeaf-5fc73ff75bf8"), Code="textual", Description="Textual", Definition="Textual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("24c7f5ae-43d4-4ee4-b8b8-e4ff28c5633e"), Code="visual", Description="Visual", Definition="Visual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("12.00") },
        };
        #endregion

        #region RefLearningResourceAccessRightsUrl List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAccessRightsUrlList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("267d76c0-3207-47f8-a4a7-16b42295b3be"), Code="FreeAccess", Description="Free Access", Definition="The right to view and/or download material without financial, registration, or excessive advertising barriers.  [<a href=\u0022https://ceds.ed.gov/element/001561#FreeAccess\u0022>https://ceds.ed.gov/element/001561#FreeAccess</a>]", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("63e04dca-d035-4372-929b-564d85de23cf"), Code="FreeAccessWithRegistration", Description="Free Access with Registration", Definition="The right to view and/or download material without financial barriers but users are required to register or experience some other low-barrier to use.  [<a href=\u0022https://ceds.ed.gov/element/001561#FreeAccessWithRegistration\u0022>https://ceds.ed.gov/element/001561#FreeAccessWithRegistration</a>]", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("97bd0fab-17fb-4135-8e8f-e8f760471619"), Code="LimitedFreeAccess", Description="Limited Free Access", Definition="Some material is available for viewing and/or downloading but most material tends to be accessible through other means.  [<a href=\u0022https://ceds.ed.gov/element/001561#LimitedFreeAccess\u0022>https://ceds.ed.gov/element/001561#LimitedFreeAccess</a>]", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("80100538-2197-4ee7-a6f1-3b8649bde31a"), Code="AvailableForPurchase", Description="Available for Purchase", Definition="The right to view, keep, and/or download material upon payment of a one-time fee.  [<a href=\u0022https://ceds.ed.gov/element/001561#AvailableForPurchase\u0022>https://ceds.ed.gov/element/001561#AvailableForPurchase</a>]", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("1d41bfd6-492f-4dc0-88d4-1ae41a2e2813"), Code="AvailableBySubscription", Description="Available by Subscription", Definition="The right to view and/or download material, often for a set period of time, by way of a financial agreement between rights holders and authorized users.  [<a href=\u0022https://ceds.ed.gov/element/001561#AvailableBySubscription\u0022>https://ceds.ed.gov/element/001561#AvailableBySubscription</a>]", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("b9fd122d-8198-462f-af32-a5e299743802"), Code="PublisherDefined", Description="Publisher Defined", Definition="Publisher defined conditions that govern the user's ability to access a learning resource.", SortOrder=Convert.ToDecimal("9.00") },
        };
        #endregion

        #region RefLearningResourceAuthorType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAuthorTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8d92ad83-d026-4928-8e33-71036ed5e309"), Code="Organization", Description="Organization", Definition="The specified author of the learning resource is an organization.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("45977964-32a6-43c2-aa5d-7a0ba3db57e4"), Code="Person", Description="Person", Definition="The specified author of the learning resource is a person.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefLearningResourceBookFormatType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceBookFormatTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("702ec56a-212d-4b92-a115-8371627a69df"), Code="Ebook", Description="Ebook", Definition="Ebook is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("5adb8ce2-3846-4af0-933c-d56e719cd0aa"), Code="Hardcover", Description="Hardcover", Definition="Hardcover is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("34febb58-bce7-4033-8f45-03a0533e7bf8"), Code="Paperback", Description="Paperback", Definition="Paperback is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("38fa583b-1ebf-4136-8984-12e0ef5a1dfd"), Code="DAISY202", Description="DAISY202", Definition="DAISY202 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("51ff44e4-83be-4e11-a4ee-531b27681330"), Code="DAISY3", Description="DAISY3", Definition="DAISY3 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad2a5c2a-9bf9-41c0-a266-3140fef91b11"), Code="EPUB2", Description="EPUB2", Definition="EPUB2 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("b3643a15-bc0f-46ca-b3d0-004a06ebe0e7"), Code="EPUB3", Description="EPUB3", Definition="EPUB3 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("d2cd9501-d94d-4d8b-b833-f1783abd7de6"), Code="Other", Description="Other", Definition="The specific format for the learning resource that is a book is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("16.00") },
        };
        #endregion

        #region RefLearningResourceControlFlexibilityType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceControlFlexibilityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("9d6cdbed-df50-42f5-b9d5-37d329ddb6fa"), Code="fullAudioControl", Description="Full Audio Control", Definition="Audio input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("b3ee32f5-59a9-44c5-aca4-5f5923cf4840"), Code="fullKeyboardControl", Description="Full Keyboard Control", Definition="Keyboard input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("7356fea3-6890-4b7c-a42f-3e90bb7a89fb"), Code="fullMouseControl", Description="Full Mouse Control", Definition="Mouse input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("35577442-9596-485a-a102-e4ef3b259df2"), Code="fullTouchControl", Description="Full Touch Control", Definition="Touch input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("0ace394d-a299-4f96-92bd-ed030dbb194f"), Code="fullVideoControl", Description="Full Video Control", Definition=" Video input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("10.00") },
        };
        #endregion

        #region RefLearningResourceDigitalMediaSubType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceDigitalMediaSubTypeList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefLearningResourceDigitalMediaType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceDigitalMediaTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("eab413d4-df6c-44d6-a33c-75b4946b9d54"), Code="application", Description="Application", Definition="The AINA registered Media Type of the digital resource is: Application", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("7417c91c-1e31-4dbe-a0d4-0eaf510fb3fa"), Code="audio", Description="Audio", Definition="The AINA registered Media Type of the digital resource is: Audio", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("f500afea-2883-48df-b183-648fbb8bf247"), Code="example", Description="Example", Definition="The AINA registered Media Type of the digital resource is: Example", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("2ed59bf3-9009-4ec3-b16f-ce7abbd2328f"), Code="image", Description="Image", Definition="The AINA registered Media Type of the digital resource is: Image", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("da8af5f8-af83-41b2-920a-883f697eaec3"), Code="message", Description="Message", Definition="The AINA registered Media Type of the digital resource is: Message", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff565780-c2c0-4888-b619-bb3ba3459ebb"), Code="model", Description="Model", Definition="The AINA registered Media Type of the digital resource is: Model", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("20cd0d61-0ee8-46ce-8d1f-c032f65f6188"), Code="multipart", Description="Multipart", Definition="The AINA registered Media Type of the digital resource is: Multipart", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d2e7c6c-deb7-4067-b146-3b0242809d09"), Code="text", Description="Text", Definition="The AINA registered Media Type of the digital resource is: Text", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("3c192ca0-dfac-4de5-ac5c-f2f3c13e176a"), Code="video", Description="Video", Definition="The AINA registered Media Type of the digital resource is: Video", SortOrder=Convert.ToDecimal("18.00") },
        };
        #endregion

        #region RefLearningResourceEducationalUse List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceEducationalUseList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("2d311311-37e8-480e-9404-786e91b18fd7"), Code="CurriculumInstruction", Description="Curriculum/Instruction", Definition="Primary purpose of the resource is to support the instructional process, student learning, or to provide information about the curriculum.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a6dc4156-e93c-40bd-ad86-8f5348d4c673"), Code="Assessment", Description="Assessment", Definition="Primary purpose of the resource is to evaluate learning, either before or after instruction occurs.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("0b2736a8-907e-4262-9a4f-82e9afb42281"), Code="ProfessionalDevelopment", Description="Professional Development", Definition="Primary purpose of the resource is to provide instruction for a teacher or other education professional.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("3b478c43-59f5-41a3-9bbc-79c2bcc24365"), Code="Other", Description="Other", Definition="Primary purpose of the resource is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefLearningResourceIntendedEndUserRole List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceIntendedEndUserRoleList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("51379f39-df79-4bb4-a5c2-52d96ccc846c"), Code="Administrator", Description="Administrator", Definition="The resource was produced for use by Administrators.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("35b72ccc-56c6-4e94-877e-6f0dcff50e08"), Code="Mentor", Description="Mentor", Definition="The resource was produced for use by Mentors.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("8b036aea-eb15-4a8e-844b-3b16eff7f4bf"), Code="Parent", Description="Parent", Definition="The resource was produced for use by Parents.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ef3908f7-9ddd-4586-95aa-faf8bdfdcb05"), Code="Peer-Tutor", Description="Peer- Tutor", Definition="The resource was produced for use by Peer-Tutors.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("4507e746-8f11-461e-9741-61fbe5b47554"), Code="Specialist", Description="Specialist", Definition="The resource was produced for use by Specialists.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("1923e266-936c-4e89-a5b4-5b26bbece47f"), Code="Student", Description="Student", Definition="The resource was produced for use by Students.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("d6df7094-785d-4fa2-9aa6-916fdce5c341"), Code="Teacher", Description="Teacher", Definition="The resource was produced for use by Teachers.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("c694824d-4d0f-4328-8c50-6225a4a67986"), Code="Team", Description="Team", Definition="The resource was produced for use by Teams.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("09e0631c-fdaf-4e78-a188-13944ede6c0a"), Code="Other", Description="Other", Definition="The resource was produced for use by a category of person or group not yet defined in the CEDS vocabulary.", SortOrder=Convert.ToDecimal("9.00") },
        };
        #endregion

        #region RefLearningResourceInteractionMode List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceInteractionModeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ef328335-06ec-4814-8192-60a23413691e"), Code="Asynchronous", Description="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", Definition="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("02c31166-ae2a-496d-b5d6-d68720727f50"), Code="Synchronous", Description="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", Definition="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefLearningResourceInteractivityType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceInteractivityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("4b75a11d-2cb7-42ba-aead-a88b1c351ab6"), Code="Active", Description="Active", Definition="The predominate mode of learning supported by the learning resource is: Active", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c625b401-83b1-4af6-afa5-4eec27e2f4ec"), Code="Expositive", Description="Expositive", Definition="The predominate mode of learning supported by the learning resource is: Expositive", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("45bc37b1-0044-46a3-8806-da12e489f1ad"), Code="Mixed", Description="Mixed", Definition="The predominate mode of learning supported by the learning resource is: Mixed", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefLearningResourceType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("2dcefb6f-968f-4bd1-98e7-5de79110ee0d"), Code="AlternateAssessment", Description="Alternate Assessment", Definition="An assessment that is used to evaluate the performance of students who are unable to participate in general state assessments even with accommodations.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("eca511c9-7069-45a6-ba36-48255d6835b7"), Code="AssessmentItem", Description="Assessment Item", Definition="A specific prompt, that defines a question or protocol for a measurable activity that triggers a response from a person used to determine whether the person has mastered a learning objective.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("f706d829-4ab1-4845-8f1a-985be651673d"), Code="Course", Description="Course", Definition="A series of units and lessons used to teach the skills and knowledge required by its curriculum.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("d2e05a70-1134-4f58-9737-ab75d904e034"), Code="DemonstrationSimulation", Description="Demonstration/Simulation", Definition="An imitation or modeling of a real-world process.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("2b8840ef-76f2-4d07-bfac-b2aecc88426c"), Code="EducatorCurriculumGuide", Description="Educator/Curriculum Guide", Definition="A document that defines what concepts should be taught and/or how a concept should be taught effectively.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("dbc05595-5579-47fc-8f21-929675b64324"), Code="FormativeAssessment", Description="Formative assessment", Definition="A process used by teachers and students during instruction that provides feedback to adjust ongoing teaching and learning to improve students' achievement of intended instructional outcomes. (CCSSO FAST SCASS, 2006)", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("e5a316e2-0417-47a1-bef8-9a9dd144ecd3"), Code="ImagesVisuals", Description="Images/Visuals", Definition="Visual media, including but not limited to pictures, graphics, diagrams, figures, illustrations, charts, and maps.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("001e5b79-22fb-46be-b927-4b475fd498b9"), Code="InterimSummativeAssessment", Description="Interim/Summative Assessment", Definition="An assessment instrument used to�evaluate student learning�at the end of an instructional unit by comparing it against some standard or benchmark. A learning resource of this type may be an \u0022assessment form,\u0022 i.e. one instance of the assessment instrument that can equate scores with another instance of the same assessment.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("1efdd608-ec98-4058-b614-daa5b97d8cf7"), Code="LearningActivity", Description="Learning Activity", Definition="Activities engaged in by the learner for the purpose of acquiring certain skills, concepts, or knowledge, whether guided by an instructor or not.  A Lesson may define one or more learning activities.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("37e8247b-ae65-4401-bbb9-db8d34f09425"), Code="Lesson", Description="Lesson", Definition="A detailed description of the course of instruction for a -short period of time that is used by a teacher to guide class instruction.� A Unit contains one or more lessons.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("b5ec9170-f161-4af8-bcf4-a5470bd5f62b"), Code="PrimarySource", Description="Primary Source", Definition="An artifact, document, recording, or other source of information that was created at the time under study and provides first-hand testimony or direct evidence concerning a topic under investigation.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("2da61b1a-2fd1-4545-a198-aff65379c7b2"), Code="RubricScoringGuide", Description="Rubric/Scoring Guide", Definition="A document or guide that is used to delineate consistent criteria for grading.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("83986768-a5f9-4ee4-b833-0f6310051089"), Code="SelfAssessment", Description="Self Assessment", Definition="An assessment in which the user gathers information about and reflects on his or her own knowledge, skills, learning, or attitudes.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("7988aeb0-5503-4509-b332-ae4bab942d5f"), Code="Text", Description="Text", Definition="The body of a printed work, to include reading passages.", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("a3a58a24-d4fc-4cb2-936d-72068f910e13"), Code="Textbook", Description="Textbook", Definition="A book used as a standard source of information on a particular subject.", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("04007475-4f37-4c97-8888-84934afeaace"), Code="Unit", Description="Unit", Definition="A long-range plan of instruction on a particular concept; it contains multiple lessons that are related.", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("1f7f45e2-8385-4437-9cb8-1c2bca2e173e"), Code="Other", Description="Other", Definition="A type of learning resource in a category not yet defined by CEDS. ", SortOrder=Convert.ToDecimal("40.00") },
        };
        #endregion
    }
}
