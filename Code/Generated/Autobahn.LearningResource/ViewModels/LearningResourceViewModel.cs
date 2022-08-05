//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResource.ViewModels
{
     /// <summary>
     /// The LearningResourceViewModel
     /// </summary>
    public partial class LearningResourceViewModel : ViewModelBase, Interfaces.ILearningResource
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResource";

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Url property
        private System.String _Url;

        // member variable for the ConceptKeyword property
        private System.String _ConceptKeyword;

        // member variable for the SubjectName property
        private System.String _SubjectName;

        // member variable for the SubjectCode property
        private System.String _SubjectCode;

        // member variable for the SubjectCodeSystem property
        private System.String _SubjectCodeSystem;

        // member variable for the RefLearningResourceTypeId property
        private Guid? _RefLearningResourceTypeId;

        // member variable for the DateCreated property
        private System.DateTime? _DateCreated;

        // member variable for the Version property
        private System.String _Version;

        // member variable for the Creator property
        private System.String _Creator;

        // member variable for the PublisherName property
        private System.String _PublisherName;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the CopyrightHolderName property
        private System.String _CopyrightHolderName;

        // member variable for the CopyrightYear property
        private System.String _CopyrightYear;

        // member variable for the LearningResourceLicenseURL property
        private System.String _LearningResourceLicenseURL;

        // member variable for the BasedOnUrl property
        private System.String _BasedOnUrl;

        // member variable for the RefLearningResourceIntendedEndUserRoleId property
        private Guid? _RefLearningResourceIntendedEndUserRoleId;

        // member variable for the RefLearningResourceEducationalUseId property
        private Guid? _RefLearningResourceEducationalUseId;

        // member variable for the RefLearningResourceInteractivityTypeId property
        private Guid? _RefLearningResourceInteractivityTypeId;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the TimeRequired property
        private System.Decimal? _TimeRequired;

        // member variable for the TypicalAgeRangeMinimum property
        private System.Byte? _TypicalAgeRangeMinimum;

        // member variable for the TypicalAgeRangeMaximum property
        private System.Byte? _TypicalAgeRangeMaximum;

        // member variable for the TextComplexityValue property
        private System.String _TextComplexityValue;

        // member variable for the TextComplexitySystem property
        private System.String _TextComplexitySystem;

        // member variable for the AdaptedFromURL property
        private System.String _AdaptedFromURL;

        // member variable for the AssistiveTechnologiesCompatibleInd property
        private System.Boolean? _AssistiveTechnologiesCompatibleInd;

        // member variable for the PeerRatingSampleSize property
        private System.Int32? _PeerRatingSampleSize;

        // member variable for the RefLearningResourceAccessAPITypeId property
        private Guid? _RefLearningResourceAccessAPITypeId;

        // member variable for the RefLearningResourceAccessHazardTypeId property
        private Guid? _RefLearningResourceAccessHazardTypeId;

        // member variable for the RefLearningResourceAccessModeTypeId property
        private Guid? _RefLearningResourceAccessModeTypeId;

        // member variable for the RefLearningResourceBookFormatTypeId property
        private Guid? _RefLearningResourceBookFormatTypeId;

        // member variable for the RefLearningResourceControlFlexibilityTypeId property
        private Guid? _RefLearningResourceControlFlexibilityTypeId;

        // member variable for the RefLearningResourceDigitalMediaSubTypeId property
        private Guid? _RefLearningResourceDigitalMediaSubTypeId;

        // member variable for the RefLearningResourceDigitalMediaTypeId property
        private Guid? _RefLearningResourceDigitalMediaTypeId;

        // member variable for the LearningResourceAuthorEmail property
        private System.String _LearningResourceAuthorEmail;

        // member variable for the LearningResourceAuthorURL property
        private System.String _LearningResourceAuthorURL;

        // member variable for the LearningResourceDateModified property
        private System.DateTime? _LearningResourceDateModified;

        // member variable for the LearningResourcePublisherEmail property
        private System.String _LearningResourcePublisherEmail;

        // member variable for the LearningResourcePublisherURL property
        private System.String _LearningResourcePublisherURL;

        // member variable for the RefLearningResourceAccessRightsUrlId property
        private Guid? _RefLearningResourceAccessRightsUrlId;

        // member variable for the RefLearningResourceAuthorTypeId property
        private Guid? _RefLearningResourceAuthorTypeId;

        // member variable for the RefLearningResourceInteractionModeId property
        private Guid? _RefLearningResourceInteractionModeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Url  { get => _Url; set => SetProperty(ref _Url, value); }

        public System.String ConceptKeyword  { get => _ConceptKeyword; set => SetProperty(ref _ConceptKeyword, value); }

        public System.String SubjectName  { get => _SubjectName; set => SetProperty(ref _SubjectName, value); }

        public System.String SubjectCode  { get => _SubjectCode; set => SetProperty(ref _SubjectCode, value); }

        public System.String SubjectCodeSystem  { get => _SubjectCodeSystem; set => SetProperty(ref _SubjectCodeSystem, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceTypeId { get => _RefLearningResourceTypeId; set => SetProperty(ref _RefLearningResourceTypeId, value); }

        public System.DateTime? DateCreated { get => _DateCreated; set => SetProperty(ref _DateCreated, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.String Creator  { get => _Creator; set => SetProperty(ref _Creator, value); }

        public System.String PublisherName  { get => _PublisherName; set => SetProperty(ref _PublisherName, value); }

        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        public System.String CopyrightHolderName  { get => _CopyrightHolderName; set => SetProperty(ref _CopyrightHolderName, value); }

        public System.String CopyrightYear  { get => _CopyrightYear; set => SetProperty(ref _CopyrightYear, value); }

        public System.String LearningResourceLicenseURL  { get => _LearningResourceLicenseURL; set => SetProperty(ref _LearningResourceLicenseURL, value); }

        public System.String BasedOnUrl  { get => _BasedOnUrl; set => SetProperty(ref _BasedOnUrl, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceIntendedEndUserRoleId"/> model
        /// </summary>
        public Guid? RefLearningResourceIntendedEndUserRoleId { get => _RefLearningResourceIntendedEndUserRoleId; set => SetProperty(ref _RefLearningResourceIntendedEndUserRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceEducationalUseId"/> model
        /// </summary>
        public Guid? RefLearningResourceEducationalUseId { get => _RefLearningResourceEducationalUseId; set => SetProperty(ref _RefLearningResourceEducationalUseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractivityTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceInteractivityTypeId { get => _RefLearningResourceInteractivityTypeId; set => SetProperty(ref _RefLearningResourceInteractivityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        public System.Decimal? TimeRequired { get => _TimeRequired; set => SetProperty(ref _TimeRequired, value); }

        public System.Byte? TypicalAgeRangeMinimum { get => _TypicalAgeRangeMinimum; set => SetProperty(ref _TypicalAgeRangeMinimum, value); }

        public System.Byte? TypicalAgeRangeMaximum { get => _TypicalAgeRangeMaximum; set => SetProperty(ref _TypicalAgeRangeMaximum, value); }

        public System.String TextComplexityValue  { get => _TextComplexityValue; set => SetProperty(ref _TextComplexityValue, value); }

        public System.String TextComplexitySystem  { get => _TextComplexitySystem; set => SetProperty(ref _TextComplexitySystem, value); }

        public System.String AdaptedFromURL  { get => _AdaptedFromURL; set => SetProperty(ref _AdaptedFromURL, value); }

        public System.Boolean? AssistiveTechnologiesCompatibleInd { get => _AssistiveTechnologiesCompatibleInd; set => SetProperty(ref _AssistiveTechnologiesCompatibleInd, value); }

        public System.Int32? PeerRatingSampleSize { get => _PeerRatingSampleSize; set => SetProperty(ref _PeerRatingSampleSize, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessAPITypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessAPITypeId { get => _RefLearningResourceAccessAPITypeId; set => SetProperty(ref _RefLearningResourceAccessAPITypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessHazardTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessHazardTypeId { get => _RefLearningResourceAccessHazardTypeId; set => SetProperty(ref _RefLearningResourceAccessHazardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessModeTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessModeTypeId { get => _RefLearningResourceAccessModeTypeId; set => SetProperty(ref _RefLearningResourceAccessModeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceBookFormatTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceBookFormatTypeId { get => _RefLearningResourceBookFormatTypeId; set => SetProperty(ref _RefLearningResourceBookFormatTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceControlFlexibilityTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceControlFlexibilityTypeId { get => _RefLearningResourceControlFlexibilityTypeId; set => SetProperty(ref _RefLearningResourceControlFlexibilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaSubTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaSubTypeId { get => _RefLearningResourceDigitalMediaSubTypeId; set => SetProperty(ref _RefLearningResourceDigitalMediaSubTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceDigitalMediaTypeId { get => _RefLearningResourceDigitalMediaTypeId; set => SetProperty(ref _RefLearningResourceDigitalMediaTypeId, value); }

        public System.String LearningResourceAuthorEmail  { get => _LearningResourceAuthorEmail; set => SetProperty(ref _LearningResourceAuthorEmail, value); }

        public System.String LearningResourceAuthorURL  { get => _LearningResourceAuthorURL; set => SetProperty(ref _LearningResourceAuthorURL, value); }

        public System.DateTime? LearningResourceDateModified { get => _LearningResourceDateModified; set => SetProperty(ref _LearningResourceDateModified, value); }

        public System.String LearningResourcePublisherEmail  { get => _LearningResourcePublisherEmail; set => SetProperty(ref _LearningResourcePublisherEmail, value); }

        public System.String LearningResourcePublisherURL  { get => _LearningResourcePublisherURL; set => SetProperty(ref _LearningResourcePublisherURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessRightsUrlId"/> model
        /// </summary>
        public Guid? RefLearningResourceAccessRightsUrlId { get => _RefLearningResourceAccessRightsUrlId; set => SetProperty(ref _RefLearningResourceAccessRightsUrlId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAuthorTypeId"/> model
        /// </summary>
        public Guid? RefLearningResourceAuthorTypeId { get => _RefLearningResourceAuthorTypeId; set => SetProperty(ref _RefLearningResourceAuthorTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractionModeId"/> model
        /// </summary>
        public Guid? RefLearningResourceInteractionModeId { get => _RefLearningResourceInteractionModeId; set => SetProperty(ref _RefLearningResourceInteractionModeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            Title = model.Title;
            Description = model.Description;
            Url = model.Url;
            ConceptKeyword = model.ConceptKeyword;
            SubjectName = model.SubjectName;
            SubjectCode = model.SubjectCode;
            SubjectCodeSystem = model.SubjectCodeSystem;
            RefLearningResourceTypeId = model.RefLearningResourceTypeId;
            DateCreated = model.DateCreated;
            Version = model.Version;
            Creator = model.Creator;
            PublisherName = model.PublisherName;
            PublishedDate = model.PublishedDate;
            CopyrightHolderName = model.CopyrightHolderName;
            CopyrightYear = model.CopyrightYear;
            LearningResourceLicenseURL = model.LearningResourceLicenseURL;
            BasedOnUrl = model.BasedOnUrl;
            RefLearningResourceIntendedEndUserRoleId = model.RefLearningResourceIntendedEndUserRoleId;
            RefLearningResourceEducationalUseId = model.RefLearningResourceEducationalUseId;
            RefLearningResourceInteractivityTypeId = model.RefLearningResourceInteractivityTypeId;
            RefLanguageId = model.RefLanguageId;
            TimeRequired = model.TimeRequired;
            TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum;
            TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum;
            TextComplexityValue = model.TextComplexityValue;
            TextComplexitySystem = model.TextComplexitySystem;
            AdaptedFromURL = model.AdaptedFromURL;
            AssistiveTechnologiesCompatibleInd = model.AssistiveTechnologiesCompatibleInd;
            PeerRatingSampleSize = model.PeerRatingSampleSize;
            RefLearningResourceAccessAPITypeId = model.RefLearningResourceAccessAPITypeId;
            RefLearningResourceAccessHazardTypeId = model.RefLearningResourceAccessHazardTypeId;
            RefLearningResourceAccessModeTypeId = model.RefLearningResourceAccessModeTypeId;
            RefLearningResourceBookFormatTypeId = model.RefLearningResourceBookFormatTypeId;
            RefLearningResourceControlFlexibilityTypeId = model.RefLearningResourceControlFlexibilityTypeId;
            RefLearningResourceDigitalMediaSubTypeId = model.RefLearningResourceDigitalMediaSubTypeId;
            RefLearningResourceDigitalMediaTypeId = model.RefLearningResourceDigitalMediaTypeId;
            LearningResourceAuthorEmail = model.LearningResourceAuthorEmail;
            LearningResourceAuthorURL = model.LearningResourceAuthorURL;
            LearningResourceDateModified = model.LearningResourceDateModified;
            LearningResourcePublisherEmail = model.LearningResourcePublisherEmail;
            LearningResourcePublisherURL = model.LearningResourcePublisherURL;
            RefLearningResourceAccessRightsUrlId = model.RefLearningResourceAccessRightsUrlId;
            RefLearningResourceAuthorTypeId = model.RefLearningResourceAuthorTypeId;
            RefLearningResourceInteractionModeId = model.RefLearningResourceInteractionModeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
