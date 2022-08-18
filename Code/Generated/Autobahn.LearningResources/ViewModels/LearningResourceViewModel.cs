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
            new ReferenceModelBase { Id=Guid.Parse("d8f30af7-8b88-4123-ac02-6732844dbc8a"), Code="AndroidAccessibility", Description="Android Accessibility", Definition="The learning resource is compatible with Android Accessibility.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f1985f7-0003-4400-b5ea-b7c78c8e293a"), Code="ARIA", Description="ARIA", Definition="The learning resource is compatible with ARIA for accessibility.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("55733790-c3c1-4548-9f2b-f0a093ea26da"), Code="ATK", Description="ATK", Definition="The learning resource is compatible with ATK for accessibility.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("f77b4f43-3a9a-4f42-b126-4f15983da555"), Code="AT-SPI", Description="AT-SPI", Definition="The learning resource is compatible with AT-SPI for accessibility.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("ab3e0099-3a19-477e-a6b3-12d8d3ab17c2"), Code="BlackberryAccessibility", Description="Blackberry Accessibility", Definition="The learning resource is compatible with Blackberry Accessibility.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("51641a0e-677b-4923-81fc-f84caec398eb"), Code="iAccessible2", Description="I Accessible2", Definition="The learning resource is compatible with I Accessible2.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("dba1d25c-31b0-4cd2-86ae-0d1e4a7075c0"), Code="iOSAccessibility", Description="iOS Accessibility", Definition="The learning resource is compatible with iOS Accessibility.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("753663ca-9792-4c29-915e-4dd847e19fec"), Code="JavaAccessibility", Description="Java Accessibility", Definition="The learning resource is compatible with Java Accessibility.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("37325c42-e290-4968-9d56-69ea38ceadea"), Code="MacOSXAccessibility", Description="Mac OSX Accessibility", Definition="The learning resource is compatible with Mac OSX Accessibility.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("f136af83-5bca-4460-85eb-e90278499fc7"), Code="MSAA", Description="MSAA", Definition="The learning resource is compatible with MSAA.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("51045b54-8b2e-4e22-b095-f440d4fab520"), Code="UIAutomation", Description="UI Automation", Definition="The learning resource is compatible with the UI Automation.", SortOrder=Convert.ToDecimal("22.00") },
        };
        #endregion

        #region RefLearningResourceAccessHazardType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAccessHazardTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("4c9b91d6-e1dc-4bba-ac10-0c286dff7374"), Code="Flashing", Description="Flashing", Definition="Flashing is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("6226c14e-bfba-47c0-8c77-580f2271fc27"), Code="MotionSimulation", Description="Motion simulation", Definition="Motion simulation is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad0cd118-0765-4561-8f05-1cd1afb7b1c7"), Code="Sound", Description="Sound", Definition="Sound is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefLearningResourceAccessModeType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAccessModeTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("f4f810d5-56f0-4c6b-910b-38185544d38a"), Code="auditory", Description="Auditory", Definition="Auditory is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("79197564-c980-4067-a25e-a112c5506d42"), Code="colorDependent", Description="Color Dependent", Definition="Color Dependent is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("02201825-d61c-4525-923c-6dd3343b04d0"), Code="tactile", Description="Tactile", Definition="Tactile is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("20b47826-2c0f-461a-9be1-c31c3b9f6a8d"), Code="textOnImage", Description="Text On Image", Definition="Text On Image is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("aab8c5d8-5ede-45d7-aa66-837c107ab621"), Code="textual", Description="Textual", Definition="Textual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("ab098963-3937-451a-9ed6-954a96cfa84e"), Code="visual", Description="Visual", Definition="Visual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("12.00") },
        };
        #endregion

        #region RefLearningResourceAccessRightsUrl List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAccessRightsUrlList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("aa672577-f204-4bdb-9565-22e8237aeef5"), Code="FreeAccess", Description="Free Access", Definition="The right to view and/or download material without financial, registration, or excessive advertising barriers.  [<a href=\u0022https://ceds.ed.gov/element/001561#FreeAccess\u0022>https://ceds.ed.gov/element/001561#FreeAccess</a>]", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("934a0e8a-abae-483c-9a0e-44c667a16bef"), Code="FreeAccessWithRegistration", Description="Free Access with Registration", Definition="The right to view and/or download material without financial barriers but users are required to register or experience some other low-barrier to use.  [<a href=\u0022https://ceds.ed.gov/element/001561#FreeAccessWithRegistration\u0022>https://ceds.ed.gov/element/001561#FreeAccessWithRegistration</a>]", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("be900da1-65ee-45fc-9233-021e4a019425"), Code="LimitedFreeAccess", Description="Limited Free Access", Definition="Some material is available for viewing and/or downloading but most material tends to be accessible through other means.  [<a href=\u0022https://ceds.ed.gov/element/001561#LimitedFreeAccess\u0022>https://ceds.ed.gov/element/001561#LimitedFreeAccess</a>]", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("356da0e6-2b5e-4a3d-aa40-45fb7d9e16b9"), Code="AvailableForPurchase", Description="Available for Purchase", Definition="The right to view, keep, and/or download material upon payment of a one-time fee.  [<a href=\u0022https://ceds.ed.gov/element/001561#AvailableForPurchase\u0022>https://ceds.ed.gov/element/001561#AvailableForPurchase</a>]", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a2a758a-4da5-43bd-a4ac-0845d5dad5a9"), Code="AvailableBySubscription", Description="Available by Subscription", Definition="The right to view and/or download material, often for a set period of time, by way of a financial agreement between rights holders and authorized users.  [<a href=\u0022https://ceds.ed.gov/element/001561#AvailableBySubscription\u0022>https://ceds.ed.gov/element/001561#AvailableBySubscription</a>]", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("e9e61658-e3ec-432f-9861-f99660c45a04"), Code="PublisherDefined", Description="Publisher Defined", Definition="Publisher defined conditions that govern the user's ability to access a learning resource.", SortOrder=Convert.ToDecimal("9.00") },
        };
        #endregion

        #region RefLearningResourceAuthorType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceAuthorTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("4924ac47-2d66-468b-82eb-3545b3248558"), Code="Organization", Description="Organization", Definition="The specified author of the learning resource is an organization.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("31f64a69-147f-4e3a-9b80-d8478106b3e1"), Code="Person", Description="Person", Definition="The specified author of the learning resource is a person.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefLearningResourceBookFormatType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceBookFormatTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("1e7edfce-7f3f-4a17-9710-e1c9da9ab8f8"), Code="Ebook", Description="Ebook", Definition="Ebook is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("35805833-2d21-426d-a2c7-b1b2ce265119"), Code="Hardcover", Description="Hardcover", Definition="Hardcover is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("e6412e71-431d-44d6-99ab-b807808f20c4"), Code="Paperback", Description="Paperback", Definition="Paperback is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("928c6846-baa3-43fd-b2c3-41effce28ab0"), Code="DAISY202", Description="DAISY202", Definition="DAISY202 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("8646fa74-4a07-45d9-a3d4-75c2f553b4ca"), Code="DAISY3", Description="DAISY3", Definition="DAISY3 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("17b8320c-ef11-416e-8f1c-75a70d665e06"), Code="EPUB2", Description="EPUB2", Definition="EPUB2 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("f07e45cc-5a91-4a83-bbc4-17ec2802707a"), Code="EPUB3", Description="EPUB3", Definition="EPUB3 is the specific format for the learning resource that is a book.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("2fb68e25-bc0e-47ab-8c73-23aeeb46cea4"), Code="Other", Description="Other", Definition="The specific format for the learning resource that is a book is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("16.00") },
        };
        #endregion

        #region RefLearningResourceControlFlexibilityType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceControlFlexibilityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("17b8cd7a-df03-4e22-b336-17132a155fd2"), Code="fullAudioControl", Description="Full Audio Control", Definition="Audio input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a3af7650-d31a-44ba-b399-fcb8f9b773cb"), Code="fullKeyboardControl", Description="Full Keyboard Control", Definition="Keyboard input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("607c7b6a-24ac-46ac-acad-100a11a574ad"), Code="fullMouseControl", Description="Full Mouse Control", Definition="Mouse input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("938faf5c-cbc5-40e0-95f6-3fe1cedbf1ac"), Code="fullTouchControl", Description="Full Touch Control", Definition="Touch input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("8669243a-9283-45c5-9a8b-a35f90f505e7"), Code="fullVideoControl", Description="Full Video Control", Definition=" Video input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("10.00") },
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
            new ReferenceModelBase { Id=Guid.Parse("0e2006a5-4c76-4862-9a65-b8f43d6e4da2"), Code="application", Description="Application", Definition="The AINA registered Media Type of the digital resource is: Application", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("185ea33c-4234-4de1-b700-2056a8d12c40"), Code="audio", Description="Audio", Definition="The AINA registered Media Type of the digital resource is: Audio", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("459a4e73-dc87-4387-885d-4fbcd031e036"), Code="example", Description="Example", Definition="The AINA registered Media Type of the digital resource is: Example", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("c661aba8-d905-4443-b76a-6e20cbcddb31"), Code="image", Description="Image", Definition="The AINA registered Media Type of the digital resource is: Image", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("4fea93d1-0a82-4352-98b0-a78cd49cde24"), Code="message", Description="Message", Definition="The AINA registered Media Type of the digital resource is: Message", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("5ab8660c-e0f5-4204-9a11-f5e7e109bdec"), Code="model", Description="Model", Definition="The AINA registered Media Type of the digital resource is: Model", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("a2098c8b-3f97-4e27-a185-97ca15c057fb"), Code="multipart", Description="Multipart", Definition="The AINA registered Media Type of the digital resource is: Multipart", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("45166053-fd14-4895-8f73-6432761c1361"), Code="text", Description="Text", Definition="The AINA registered Media Type of the digital resource is: Text", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("c1593bf2-7b38-4e62-acf3-a9efe3484ca0"), Code="video", Description="Video", Definition="The AINA registered Media Type of the digital resource is: Video", SortOrder=Convert.ToDecimal("18.00") },
        };
        #endregion

        #region RefLearningResourceEducationalUse List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceEducationalUseList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("10651385-0183-44d3-9a4f-48d1192d613d"), Code="CurriculumInstruction", Description="Curriculum/Instruction", Definition="Primary purpose of the resource is to support the instructional process, student learning, or to provide information about the curriculum.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("5936060e-6750-4a56-b800-36afe5a5762a"), Code="Assessment", Description="Assessment", Definition="Primary purpose of the resource is to evaluate learning, either before or after instruction occurs.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c387f13d-810d-4402-8be6-6402d3365c26"), Code="ProfessionalDevelopment", Description="Professional Development", Definition="Primary purpose of the resource is to provide instruction for a teacher or other education professional.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("43ecef21-bf8d-450b-b406-fcd8986816b0"), Code="Other", Description="Other", Definition="Primary purpose of the resource is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefLearningResourceIntendedEndUserRole List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceIntendedEndUserRoleList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("5558ff65-2633-41a8-a827-935f36b9a695"), Code="Administrator", Description="Administrator", Definition="The resource was produced for use by Administrators.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("a182c4a9-449c-4575-898d-eaea154eda68"), Code="Mentor", Description="Mentor", Definition="The resource was produced for use by Mentors.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("c39c5d42-003a-40f9-8c86-1500e673bb1e"), Code="Parent", Description="Parent", Definition="The resource was produced for use by Parents.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("b103b806-6fbe-4d6c-9e9f-963d181aea5e"), Code="Peer-Tutor", Description="Peer- Tutor", Definition="The resource was produced for use by Peer-Tutors.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("7f0d6486-92ea-4acd-9173-56a43d41d77a"), Code="Specialist", Description="Specialist", Definition="The resource was produced for use by Specialists.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("750eb344-69ec-4ab0-b67c-caa457e911af"), Code="Student", Description="Student", Definition="The resource was produced for use by Students.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("880805ef-f8ed-4227-a3d0-c76c3197a152"), Code="Teacher", Description="Teacher", Definition="The resource was produced for use by Teachers.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("2d965641-7454-4d99-a2a9-6798f4b8ae8c"), Code="Team", Description="Team", Definition="The resource was produced for use by Teams.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("d1729b36-4071-4283-a0eb-978e887c5114"), Code="Other", Description="Other", Definition="The resource was produced for use by a category of person or group not yet defined in the CEDS vocabulary.", SortOrder=Convert.ToDecimal("9.00") },
        };
        #endregion

        #region RefLearningResourceInteractionMode List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceInteractionModeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("7a61aad0-0d36-47d8-996b-fb04541596ec"), Code="Asynchronous", Description="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", Definition="Student-oriented teaching and learning which is not organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2fbf7664-c63c-400e-9f30-704cb63dcc8f"), Code="Synchronous", Description="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", Definition="Group-oriented teaching and learning organized around participants interacting at the same time and in the same space.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefLearningResourceInteractivityType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceInteractivityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("310ec410-6ec1-4306-800a-d74cfaa11e89"), Code="Active", Description="Active", Definition="The predominate mode of learning supported by the learning resource is: Active", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("191df4cb-c40c-4984-8762-e942463cd627"), Code="Expositive", Description="Expositive", Definition="The predominate mode of learning supported by the learning resource is: Expositive", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("24a83f7d-b036-4cb8-b674-917e3783cc0c"), Code="Mixed", Description="Mixed", Definition="The predominate mode of learning supported by the learning resource is: Mixed", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefLearningResourceType List
        /// <summary>
        /// The complete Learning Resource Adapted From URL List
        /// </summary>
        private static List<ReferenceModelBase> RefLearningResourceTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("5c342647-6faa-4251-be1d-2971ba283e6d"), Code="AlternateAssessment", Description="Alternate Assessment", Definition="An assessment that is used to evaluate the performance of students who are unable to participate in general state assessments even with accommodations.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("8524cb45-afc9-4d63-a9b3-767476519f83"), Code="AssessmentItem", Description="Assessment Item", Definition="A specific prompt, that defines a question or protocol for a measurable activity that triggers a response from a person used to determine whether the person has mastered a learning objective.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("12381393-a287-4760-b8de-a29141161444"), Code="Course", Description="Course", Definition="A series of units and lessons used to teach the skills and knowledge required by its curriculum.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("b30c09f8-417d-4d0a-988c-66bc924b7352"), Code="DemonstrationSimulation", Description="Demonstration/Simulation", Definition="An imitation or modeling of a real-world process.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("9cfaed19-ce4e-4ceb-9718-59346cd2c45d"), Code="EducatorCurriculumGuide", Description="Educator/Curriculum Guide", Definition="A document that defines what concepts should be taught and/or how a concept should be taught effectively.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("642b89de-5808-460f-a9c1-c8dfa99cb067"), Code="FormativeAssessment", Description="Formative assessment", Definition="A process used by teachers and students during instruction that provides feedback to adjust ongoing teaching and learning to improve students' achievement of intended instructional outcomes. (CCSSO FAST SCASS, 2006)", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("16f98007-4444-4e76-a0f7-ef2d1857d24f"), Code="ImagesVisuals", Description="Images/Visuals", Definition="Visual media, including but not limited to pictures, graphics, diagrams, figures, illustrations, charts, and maps.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("74801d86-9191-4c81-8613-fdf888ecdba2"), Code="InterimSummativeAssessment", Description="Interim/Summative Assessment", Definition="An assessment instrument used to�evaluate student learning�at the end of an instructional unit by comparing it against some standard or benchmark. A learning resource of this type may be an \u0022assessment form,\u0022 i.e. one instance of the assessment instrument that can equate scores with another instance of the same assessment.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("4070c250-2958-4076-9952-d6ba6faf6615"), Code="LearningActivity", Description="Learning Activity", Definition="Activities engaged in by the learner for the purpose of acquiring certain skills, concepts, or knowledge, whether guided by an instructor or not.  A Lesson may define one or more learning activities.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("1df7c77d-7490-48ae-89f7-b4a2c47c4964"), Code="Lesson", Description="Lesson", Definition="A detailed description of the course of instruction for a -short period of time that is used by a teacher to guide class instruction.� A Unit contains one or more lessons.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("91603add-f01e-404b-8589-f480dee0da98"), Code="PrimarySource", Description="Primary Source", Definition="An artifact, document, recording, or other source of information that was created at the time under study and provides first-hand testimony or direct evidence concerning a topic under investigation.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("09743e11-8a6e-490e-99c1-aaac2cec9a19"), Code="RubricScoringGuide", Description="Rubric/Scoring Guide", Definition="A document or guide that is used to delineate consistent criteria for grading.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("26283d27-9d06-4197-863f-1576da32f8d2"), Code="SelfAssessment", Description="Self Assessment", Definition="An assessment in which the user gathers information about and reflects on his or her own knowledge, skills, learning, or attitudes.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("0cce7865-c090-4a32-b62e-9a37443388c2"), Code="Text", Description="Text", Definition="The body of a printed work, to include reading passages.", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("0f1ab9b9-b1a6-485e-b769-e0c4b6c994d5"), Code="Textbook", Description="Textbook", Definition="A book used as a standard source of information on a particular subject.", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("233bb648-61c6-4ad0-81fc-da45e4c2ac9e"), Code="Unit", Description="Unit", Definition="A long-range plan of instruction on a particular concept; it contains multiple lessons that are related.", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("d59efa49-6e6b-4f0b-92b3-b32a976a4468"), Code="Other", Description="Other", Definition="A type of learning resource in a category not yet defined by CEDS. ", SortOrder=Convert.ToDecimal("40.00") },
        };
        #endregion
    }
}
