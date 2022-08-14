//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourceViewModel
     /// </summary>
    public partial class LearningResourceViewModel : ViewModelBase, Interfaces.ILearningResource
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResource";

        // member variable for the AdaptedFromURL property
        private System.String _AdaptedFromURL;

        // member variable for the AssistiveTechnologiesCompatibleInd property
        private System.Boolean? _AssistiveTechnologiesCompatibleInd;

        // member variable for the BasedOnUrl property
        private System.String _BasedOnUrl;

        // member variable for the ConceptKeyword property
        private System.String _ConceptKeyword;

        // member variable for the CopyrightHolderName property
        private System.String _CopyrightHolderName;

        // member variable for the CopyrightYear property
        private System.String _CopyrightYear;

        // member variable for the Creator property
        private System.String _Creator;

        // member variable for the DateCreated property
        private System.DateTime? _DateCreated;

        // member variable for the LearningResourceAuthorEmail property
        private System.String _LearningResourceAuthorEmail;

        // member variable for the LearningResourceAuthorURL property
        private System.String _LearningResourceAuthorURL;

        // member variable for the LearningResourceDateModified property
        private System.DateTime? _LearningResourceDateModified;

        // member variable for the LearningResourceLicenseURL property
        private System.String _LearningResourceLicenseURL;

        // member variable for the LearningResourcePublisherEmail property
        private System.String _LearningResourcePublisherEmail;

        // member variable for the LearningResourcePublisherURL property
        private System.String _LearningResourcePublisherURL;

        // member variable for the PeerRatingSampleSize property
        private System.Int32? _PeerRatingSampleSize;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the PublisherName property
        private System.String _PublisherName;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the RefLearningResourceAccessAPITypeId property
        private Guid? _RefLearningResourceAccessAPITypeId;

        // member variable for the RefLearningResourceAccessHazardTypeId property
        private Guid? _RefLearningResourceAccessHazardTypeId;

        // member variable for the RefLearningResourceAccessModeTypeId property
        private Guid? _RefLearningResourceAccessModeTypeId;

        // member variable for the RefLearningResourceAccessRightsUrlId property
        private Guid? _RefLearningResourceAccessRightsUrlId;

        // member variable for the RefLearningResourceAuthorTypeId property
        private Guid? _RefLearningResourceAuthorTypeId;

        // member variable for the RefLearningResourceBookFormatTypeId property
        private Guid? _RefLearningResourceBookFormatTypeId;

        // member variable for the RefLearningResourceControlFlexibilityTypeId property
        private Guid? _RefLearningResourceControlFlexibilityTypeId;

        // member variable for the RefLearningResourceDigitalMediaSubTypeId property
        private Guid? _RefLearningResourceDigitalMediaSubTypeId;

        // member variable for the RefLearningResourceDigitalMediaTypeId property
        private Guid? _RefLearningResourceDigitalMediaTypeId;

        // member variable for the RefLearningResourceEducationalUseId property
        private Guid? _RefLearningResourceEducationalUseId;

        // member variable for the RefLearningResourceIntendedEndUserRoleId property
        private Guid? _RefLearningResourceIntendedEndUserRoleId;

        // member variable for the RefLearningResourceInteractionModeId property
        private Guid? _RefLearningResourceInteractionModeId;

        // member variable for the RefLearningResourceInteractivityTypeId property
        private Guid? _RefLearningResourceInteractivityTypeId;

        // member variable for the RefLearningResourceTypeId property
        private Guid? _RefLearningResourceTypeId;

        // member variable for the SubjectCode property
        private System.String _SubjectCode;

        // member variable for the SubjectCodeSystem property
        private System.String _SubjectCodeSystem;

        // member variable for the SubjectName property
        private System.String _SubjectName;

        // member variable for the TextComplexitySystem property
        private System.String _TextComplexitySystem;

        // member variable for the TextComplexityValue property
        private System.String _TextComplexityValue;

        // member variable for the TimeRequired property
        private System.Decimal? _TimeRequired;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the TypicalAgeRangeMaximum property
        private System.Byte? _TypicalAgeRangeMaximum;

        // member variable for the TypicalAgeRangeMinimum property
        private System.Byte? _TypicalAgeRangeMinimum;

        // member variable for the Url property
        private System.String _Url;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String AdaptedFromURL { get => _AdaptedFromURL; set => SetProperty(ref _AdaptedFromURL, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Boolean? AssistiveTechnologiesCompatibleInd { get => _AssistiveTechnologiesCompatibleInd; set => SetProperty(ref _AssistiveTechnologiesCompatibleInd, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String BasedOnUrl { get => _BasedOnUrl; set => SetProperty(ref _BasedOnUrl, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String ConceptKeyword { get => _ConceptKeyword; set => SetProperty(ref _ConceptKeyword, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String CopyrightHolderName { get => _CopyrightHolderName; set => SetProperty(ref _CopyrightHolderName, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String CopyrightYear { get => _CopyrightYear; set => SetProperty(ref _CopyrightYear, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String Creator { get => _Creator; set => SetProperty(ref _Creator, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.DateTime? DateCreated { get => _DateCreated; set => SetProperty(ref _DateCreated, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourceAuthorEmail { get => _LearningResourceAuthorEmail; set => SetProperty(ref _LearningResourceAuthorEmail, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourceAuthorURL { get => _LearningResourceAuthorURL; set => SetProperty(ref _LearningResourceAuthorURL, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.DateTime? LearningResourceDateModified { get => _LearningResourceDateModified; set => SetProperty(ref _LearningResourceDateModified, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourceLicenseURL { get => _LearningResourceLicenseURL; set => SetProperty(ref _LearningResourceLicenseURL, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourcePublisherEmail { get => _LearningResourcePublisherEmail; set => SetProperty(ref _LearningResourcePublisherEmail, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String LearningResourcePublisherURL { get => _LearningResourcePublisherURL; set => SetProperty(ref _LearningResourcePublisherURL, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Int32? PeerRatingSampleSize { get => _PeerRatingSampleSize; set => SetProperty(ref _PeerRatingSampleSize, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String PublisherName { get => _PublisherName; set => SetProperty(ref _PublisherName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessAPIType"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessAPITypeId { get => _RefLearningResourceAccessAPITypeId; set => SetProperty(ref _RefLearningResourceAccessAPITypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessHazardType"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessHazardTypeId { get => _RefLearningResourceAccessHazardTypeId; set => SetProperty(ref _RefLearningResourceAccessHazardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessModeType"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessModeTypeId { get => _RefLearningResourceAccessModeTypeId; set => SetProperty(ref _RefLearningResourceAccessModeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessRightsUrl"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessRightsUrlId { get => _RefLearningResourceAccessRightsUrlId; set => SetProperty(ref _RefLearningResourceAccessRightsUrlId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAuthorType"/> model
        /// </summary>
        public Guid? RefLearningResourceAuthorTypeId { get => _RefLearningResourceAuthorTypeId; set => SetProperty(ref _RefLearningResourceAuthorTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceBookFormatType"/> model
        /// </summary>
        public Guid? RefLearningResourceBookFormatTypeId { get => _RefLearningResourceBookFormatTypeId; set => SetProperty(ref _RefLearningResourceBookFormatTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceControlFlexibilityType"/> model
        /// </summary>
        public Guid? RefLearningResourceControlFlexibilityTypeId { get => _RefLearningResourceControlFlexibilityTypeId; set => SetProperty(ref _RefLearningResourceControlFlexibilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaSubType"/> model
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaSubTypeId { get => _RefLearningResourceDigitalMediaSubTypeId; set => SetProperty(ref _RefLearningResourceDigitalMediaSubTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaType"/> model
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaTypeId { get => _RefLearningResourceDigitalMediaTypeId; set => SetProperty(ref _RefLearningResourceDigitalMediaTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceEducationalUse"/> model
        /// </summary>
        public Guid? RefLearningResourceEducationalUseId { get => _RefLearningResourceEducationalUseId; set => SetProperty(ref _RefLearningResourceEducationalUseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceIntendedEndUserRole"/> model
        /// </summary>
        public Guid? RefLearningResourceIntendedEndUserRoleId { get => _RefLearningResourceIntendedEndUserRoleId; set => SetProperty(ref _RefLearningResourceIntendedEndUserRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractionMode"/> model
        /// </summary>
        public Guid? RefLearningResourceInteractionModeId { get => _RefLearningResourceInteractionModeId; set => SetProperty(ref _RefLearningResourceInteractionModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractivityType"/> model
        /// </summary>
        public Guid? RefLearningResourceInteractivityTypeId { get => _RefLearningResourceInteractivityTypeId; set => SetProperty(ref _RefLearningResourceInteractivityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceType"/> model
        /// </summary>
        public Guid? RefLearningResourceTypeId { get => _RefLearningResourceTypeId; set => SetProperty(ref _RefLearningResourceTypeId, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String SubjectCode { get => _SubjectCode; set => SetProperty(ref _SubjectCode, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String SubjectCodeSystem { get => _SubjectCodeSystem; set => SetProperty(ref _SubjectCodeSystem, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String SubjectName { get => _SubjectName; set => SetProperty(ref _SubjectName, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String TextComplexitySystem { get => _TextComplexitySystem; set => SetProperty(ref _TextComplexitySystem, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String TextComplexityValue { get => _TextComplexityValue; set => SetProperty(ref _TextComplexityValue, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Decimal? TimeRequired { get => _TimeRequired; set => SetProperty(ref _TimeRequired, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Byte? TypicalAgeRangeMaximum { get => _TypicalAgeRangeMaximum; set => SetProperty(ref _TypicalAgeRangeMaximum, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.Byte? TypicalAgeRangeMinimum { get => _TypicalAgeRangeMinimum; set => SetProperty(ref _TypicalAgeRangeMinimum, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String Url { get => _Url; set => SetProperty(ref _Url, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
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
            AdaptedFromURL = model.AdaptedFromURL;
            AssistiveTechnologiesCompatibleInd = model.AssistiveTechnologiesCompatibleInd;
            BasedOnUrl = model.BasedOnUrl;
            ConceptKeyword = model.ConceptKeyword;
            CopyrightHolderName = model.CopyrightHolderName;
            CopyrightYear = model.CopyrightYear;
            Creator = model.Creator;
            DateCreated = model.DateCreated;
            LearningResourceAuthorEmail = model.LearningResourceAuthorEmail;
            LearningResourceAuthorURL = model.LearningResourceAuthorURL;
            LearningResourceDateModified = model.LearningResourceDateModified;
            LearningResourceLicenseURL = model.LearningResourceLicenseURL;
            LearningResourcePublisherEmail = model.LearningResourcePublisherEmail;
            LearningResourcePublisherURL = model.LearningResourcePublisherURL;
            PeerRatingSampleSize = model.PeerRatingSampleSize;
            PublishedDate = model.PublishedDate;
            PublisherName = model.PublisherName;
            RefLanguageId = model.RefLanguageId;
            RefLearningResourceAccessAPITypeId = model.RefLearningResourceAccessAPITypeId;
            RefLearningResourceAccessHazardTypeId = model.RefLearningResourceAccessHazardTypeId;
            RefLearningResourceAccessModeTypeId = model.RefLearningResourceAccessModeTypeId;
            RefLearningResourceAccessRightsUrlId = model.RefLearningResourceAccessRightsUrlId;
            RefLearningResourceAuthorTypeId = model.RefLearningResourceAuthorTypeId;
            RefLearningResourceBookFormatTypeId = model.RefLearningResourceBookFormatTypeId;
            RefLearningResourceControlFlexibilityTypeId = model.RefLearningResourceControlFlexibilityTypeId;
            RefLearningResourceDigitalMediaSubTypeId = model.RefLearningResourceDigitalMediaSubTypeId;
            RefLearningResourceDigitalMediaTypeId = model.RefLearningResourceDigitalMediaTypeId;
            RefLearningResourceEducationalUseId = model.RefLearningResourceEducationalUseId;
            RefLearningResourceIntendedEndUserRoleId = model.RefLearningResourceIntendedEndUserRoleId;
            RefLearningResourceInteractionModeId = model.RefLearningResourceInteractionModeId;
            RefLearningResourceInteractivityTypeId = model.RefLearningResourceInteractivityTypeId;
            RefLearningResourceTypeId = model.RefLearningResourceTypeId;
            SubjectCode = model.SubjectCode;
            SubjectCodeSystem = model.SubjectCodeSystem;
            SubjectName = model.SubjectName;
            TextComplexitySystem = model.TextComplexitySystem;
            TextComplexityValue = model.TextComplexityValue;
            TimeRequired = model.TimeRequired;
            Title = model.Title;
            TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum;
            TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum;
            Url = model.Url;
            Version = model.Version;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
