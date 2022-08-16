//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AdaptedFromURL;

        // member variable for the AssistiveTechnologiesCompatibleInd property
        private  _AssistiveTechnologiesCompatibleInd;

        // member variable for the BasedOnUrl property
        private  _BasedOnUrl;

        // member variable for the ConceptKeyword property
        private  _ConceptKeyword;

        // member variable for the CopyrightHolderName property
        private  _CopyrightHolderName;

        // member variable for the CopyrightYear property
        private  _CopyrightYear;

        // member variable for the Creator property
        private  _Creator;

        // member variable for the DateCreated property
        private  _DateCreated;

        // member variable for the Description property
        private  _Description;

        // member variable for the LearningResourceAuthorEmail property
        private  _LearningResourceAuthorEmail;

        // member variable for the LearningResourceAuthorURL property
        private  _LearningResourceAuthorURL;

        // member variable for the LearningResourceDateModified property
        private  _LearningResourceDateModified;

        // member variable for the LearningResourceLicenseURL property
        private  _LearningResourceLicenseURL;

        // member variable for the LearningResourcePublisherEmail property
        private  _LearningResourcePublisherEmail;

        // member variable for the LearningResourcePublisherURL property
        private  _LearningResourcePublisherURL;

        // member variable for the PeerRatingSampleSize property
        private  _PeerRatingSampleSize;

        // member variable for the PublishedDate property
        private  _PublishedDate;

        // member variable for the PublisherName property
        private  _PublisherName;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefLanguageId property
        private  _RefLanguageId;

        // member variable for the RefLearningResourceAccessAPITypeId property
        private  _RefLearningResourceAccessAPITypeId;

        // member variable for the RefLearningResourceAccessHazardTypeId property
        private  _RefLearningResourceAccessHazardTypeId;

        // member variable for the RefLearningResourceAccessModeTypeId property
        private  _RefLearningResourceAccessModeTypeId;

        // member variable for the RefLearningResourceAccessRightsUrlId property
        private  _RefLearningResourceAccessRightsUrlId;

        // member variable for the RefLearningResourceAuthorTypeId property
        private  _RefLearningResourceAuthorTypeId;

        // member variable for the RefLearningResourceBookFormatTypeId property
        private  _RefLearningResourceBookFormatTypeId;

        // member variable for the RefLearningResourceControlFlexibilityTypeId property
        private  _RefLearningResourceControlFlexibilityTypeId;

        // member variable for the RefLearningResourceDigitalMediaSubTypeId property
        private  _RefLearningResourceDigitalMediaSubTypeId;

        // member variable for the RefLearningResourceDigitalMediaTypeId property
        private  _RefLearningResourceDigitalMediaTypeId;

        // member variable for the RefLearningResourceEducationalUseId property
        private  _RefLearningResourceEducationalUseId;

        // member variable for the RefLearningResourceIntendedEndUserRoleId property
        private  _RefLearningResourceIntendedEndUserRoleId;

        // member variable for the RefLearningResourceInteractionModeId property
        private  _RefLearningResourceInteractionModeId;

        // member variable for the RefLearningResourceInteractivityTypeId property
        private  _RefLearningResourceInteractivityTypeId;

        // member variable for the RefLearningResourceTypeId property
        private  _RefLearningResourceTypeId;

        // member variable for the SubjectCode property
        private  _SubjectCode;

        // member variable for the SubjectCodeSystem property
        private  _SubjectCodeSystem;

        // member variable for the SubjectName property
        private  _SubjectName;

        // member variable for the TextComplexitySystem property
        private  _TextComplexitySystem;

        // member variable for the TextComplexityValue property
        private  _TextComplexityValue;

        // member variable for the TimeRequired property
        private  _TimeRequired;

        // member variable for the Title property
        private  _Title;

        // member variable for the TypicalAgeRangeMaximum property
        private  _TypicalAgeRangeMaximum;

        // member variable for the TypicalAgeRangeMinimum property
        private  _TypicalAgeRangeMinimum;

        // member variable for the Url property
        private Guid? _Url;

        // member variable for the Version property
        private  _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AdaptedFromURL { get => _AdaptedFromURL; set => SetProperty(ref _AdaptedFromURL, value); }

        /// <summary>
        /// </summary>
        public  AssistiveTechnologiesCompatibleInd { get => _AssistiveTechnologiesCompatibleInd; set => SetProperty(ref _AssistiveTechnologiesCompatibleInd, value); }

        /// <summary>
        /// </summary>
        public  BasedOnUrl { get => _BasedOnUrl; set => SetProperty(ref _BasedOnUrl, value); }

        /// <summary>
        /// </summary>
        public  ConceptKeyword { get => _ConceptKeyword; set => SetProperty(ref _ConceptKeyword, value); }

        /// <summary>
        /// </summary>
        public  CopyrightHolderName { get => _CopyrightHolderName; set => SetProperty(ref _CopyrightHolderName, value); }

        /// <summary>
        /// </summary>
        public  CopyrightYear { get => _CopyrightYear; set => SetProperty(ref _CopyrightYear, value); }

        /// <summary>
        /// </summary>
        public  Creator { get => _Creator; set => SetProperty(ref _Creator, value); }

        /// <summary>
        /// </summary>
        public  DateCreated { get => _DateCreated; set => SetProperty(ref _DateCreated, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  LearningResourceAuthorEmail { get => _LearningResourceAuthorEmail; set => SetProperty(ref _LearningResourceAuthorEmail, value); }

        /// <summary>
        /// </summary>
        public  LearningResourceAuthorURL { get => _LearningResourceAuthorURL; set => SetProperty(ref _LearningResourceAuthorURL, value); }

        /// <summary>
        /// </summary>
        public  LearningResourceDateModified { get => _LearningResourceDateModified; set => SetProperty(ref _LearningResourceDateModified, value); }

        /// <summary>
        /// </summary>
        public  LearningResourceLicenseURL { get => _LearningResourceLicenseURL; set => SetProperty(ref _LearningResourceLicenseURL, value); }

        /// <summary>
        /// </summary>
        public  LearningResourcePublisherEmail { get => _LearningResourcePublisherEmail; set => SetProperty(ref _LearningResourcePublisherEmail, value); }

        /// <summary>
        /// </summary>
        public  LearningResourcePublisherURL { get => _LearningResourcePublisherURL; set => SetProperty(ref _LearningResourcePublisherURL, value); }

        /// <summary>
        /// </summary>
        public  PeerRatingSampleSize { get => _PeerRatingSampleSize; set => SetProperty(ref _PeerRatingSampleSize, value); }

        /// <summary>
        /// </summary>
        public  PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// </summary>
        public  PublisherName { get => _PublisherName; set => SetProperty(ref _PublisherName, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public  RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessAPIType"/> model
        /// </summary>
        public  RefLearningResourceAccessAPITypeId { get => _RefLearningResourceAccessAPITypeId; set => SetProperty(ref _RefLearningResourceAccessAPITypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessHazardType"/> model
        /// </summary>
        public  RefLearningResourceAccessHazardTypeId { get => _RefLearningResourceAccessHazardTypeId; set => SetProperty(ref _RefLearningResourceAccessHazardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessModeType"/> model
        /// </summary>
        public  RefLearningResourceAccessModeTypeId { get => _RefLearningResourceAccessModeTypeId; set => SetProperty(ref _RefLearningResourceAccessModeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAccessRightsUrl"/> model
        /// </summary>
        public  RefLearningResourceAccessRightsUrlId { get => _RefLearningResourceAccessRightsUrlId; set => SetProperty(ref _RefLearningResourceAccessRightsUrlId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceAuthorType"/> model
        /// </summary>
        public  RefLearningResourceAuthorTypeId { get => _RefLearningResourceAuthorTypeId; set => SetProperty(ref _RefLearningResourceAuthorTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceBookFormatType"/> model
        /// </summary>
        public  RefLearningResourceBookFormatTypeId { get => _RefLearningResourceBookFormatTypeId; set => SetProperty(ref _RefLearningResourceBookFormatTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceControlFlexibilityType"/> model
        /// </summary>
        public  RefLearningResourceControlFlexibilityTypeId { get => _RefLearningResourceControlFlexibilityTypeId; set => SetProperty(ref _RefLearningResourceControlFlexibilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaSubType"/> model
        /// </summary>
        public  RefLearningResourceDigitalMediaSubTypeId { get => _RefLearningResourceDigitalMediaSubTypeId; set => SetProperty(ref _RefLearningResourceDigitalMediaSubTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceDigitalMediaType"/> model
        /// </summary>
        public  RefLearningResourceDigitalMediaTypeId { get => _RefLearningResourceDigitalMediaTypeId; set => SetProperty(ref _RefLearningResourceDigitalMediaTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceEducationalUse"/> model
        /// </summary>
        public  RefLearningResourceEducationalUseId { get => _RefLearningResourceEducationalUseId; set => SetProperty(ref _RefLearningResourceEducationalUseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceIntendedEndUserRole"/> model
        /// </summary>
        public  RefLearningResourceIntendedEndUserRoleId { get => _RefLearningResourceIntendedEndUserRoleId; set => SetProperty(ref _RefLearningResourceIntendedEndUserRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractionMode"/> model
        /// </summary>
        public  RefLearningResourceInteractionModeId { get => _RefLearningResourceInteractionModeId; set => SetProperty(ref _RefLearningResourceInteractionModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceInteractivityType"/> model
        /// </summary>
        public  RefLearningResourceInteractivityTypeId { get => _RefLearningResourceInteractivityTypeId; set => SetProperty(ref _RefLearningResourceInteractivityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceType"/> model
        /// </summary>
        public  RefLearningResourceTypeId { get => _RefLearningResourceTypeId; set => SetProperty(ref _RefLearningResourceTypeId, value); }

        /// <summary>
        /// </summary>
        public  SubjectCode { get => _SubjectCode; set => SetProperty(ref _SubjectCode, value); }

        /// <summary>
        /// </summary>
        public  SubjectCodeSystem { get => _SubjectCodeSystem; set => SetProperty(ref _SubjectCodeSystem, value); }

        /// <summary>
        /// </summary>
        public  SubjectName { get => _SubjectName; set => SetProperty(ref _SubjectName, value); }

        /// <summary>
        /// </summary>
        public  TextComplexitySystem { get => _TextComplexitySystem; set => SetProperty(ref _TextComplexitySystem, value); }

        /// <summary>
        /// </summary>
        public  TextComplexityValue { get => _TextComplexityValue; set => SetProperty(ref _TextComplexityValue, value); }

        /// <summary>
        /// </summary>
        public  TimeRequired { get => _TimeRequired; set => SetProperty(ref _TimeRequired, value); }

        /// <summary>
        /// </summary>
        public  Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// </summary>
        public  TypicalAgeRangeMaximum { get => _TypicalAgeRangeMaximum; set => SetProperty(ref _TypicalAgeRangeMaximum, value); }

        /// <summary>
        /// </summary>
        public  TypicalAgeRangeMinimum { get => _TypicalAgeRangeMinimum; set => SetProperty(ref _TypicalAgeRangeMinimum, value); }

        /// <summary>
        /// </summary>
        public Guid? Url { get => _Url; set => SetProperty(ref _Url, value); }

        /// <summary>
        /// </summary>
        public  Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptedFromURL = model.AdaptedFromURL; // 
            AssistiveTechnologiesCompatibleInd = model.AssistiveTechnologiesCompatibleInd; // 
            BasedOnUrl = model.BasedOnUrl; // 
            ConceptKeyword = model.ConceptKeyword; // 
            CopyrightHolderName = model.CopyrightHolderName; // 
            CopyrightYear = model.CopyrightYear; // 
            Creator = model.Creator; // 
            DateCreated = model.DateCreated; // 
            Description = model.Description; // 
            LearningResourceAuthorEmail = model.LearningResourceAuthorEmail; // 
            LearningResourceAuthorURL = model.LearningResourceAuthorURL; // 
            LearningResourceDateModified = model.LearningResourceDateModified; // 
            LearningResourceLicenseURL = model.LearningResourceLicenseURL; // 
            LearningResourcePublisherEmail = model.LearningResourcePublisherEmail; // 
            LearningResourcePublisherURL = model.LearningResourcePublisherURL; // 
            PeerRatingSampleSize = model.PeerRatingSampleSize; // 
            PublishedDate = model.PublishedDate; // 
            PublisherName = model.PublisherName; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefLanguageId = model.RefLanguageId; // 
            RefLearningResourceAccessAPITypeId = model.RefLearningResourceAccessAPITypeId; // 
            RefLearningResourceAccessHazardTypeId = model.RefLearningResourceAccessHazardTypeId; // 
            RefLearningResourceAccessModeTypeId = model.RefLearningResourceAccessModeTypeId; // 
            RefLearningResourceAccessRightsUrlId = model.RefLearningResourceAccessRightsUrlId; // 
            RefLearningResourceAuthorTypeId = model.RefLearningResourceAuthorTypeId; // 
            RefLearningResourceBookFormatTypeId = model.RefLearningResourceBookFormatTypeId; // 
            RefLearningResourceControlFlexibilityTypeId = model.RefLearningResourceControlFlexibilityTypeId; // 
            RefLearningResourceDigitalMediaSubTypeId = model.RefLearningResourceDigitalMediaSubTypeId; // 
            RefLearningResourceDigitalMediaTypeId = model.RefLearningResourceDigitalMediaTypeId; // 
            RefLearningResourceEducationalUseId = model.RefLearningResourceEducationalUseId; // 
            RefLearningResourceIntendedEndUserRoleId = model.RefLearningResourceIntendedEndUserRoleId; // 
            RefLearningResourceInteractionModeId = model.RefLearningResourceInteractionModeId; // 
            RefLearningResourceInteractivityTypeId = model.RefLearningResourceInteractivityTypeId; // 
            RefLearningResourceTypeId = model.RefLearningResourceTypeId; // 
            SubjectCode = model.SubjectCode; // 
            SubjectCodeSystem = model.SubjectCodeSystem; // 
            SubjectName = model.SubjectName; // 
            TextComplexitySystem = model.TextComplexitySystem; // 
            TextComplexityValue = model.TextComplexityValue; // 
            TimeRequired = model.TimeRequired; // 
            Title = model.Title; // 
            TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum; // 
            TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum; // 
            Url = model.Url; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
