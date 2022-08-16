//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormViewModel
     /// </summary>
    public partial class AssessmentFormViewModel : ViewModelBase, Interfaces.IAssessmentForm
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentForm";

        // member variable for the AccommodationList property
        private  _AccommodationList;

        // member variable for the AssessmentFormAdaptiveIndicator property
        private  _AssessmentFormAdaptiveIndicator;

        // member variable for the AssessmentFormAlgorithmIdentifier property
        private  _AssessmentFormAlgorithmIdentifier;

        // member variable for the AssessmentFormAlgorithmVersion property
        private  _AssessmentFormAlgorithmVersion;

        // member variable for the AssessmentFormGUID property
        private  _AssessmentFormGUID;

        // member variable for the AssessmentItemBankIdentifier property
        private  _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private  _AssessmentItemBankName;

        // member variable for the AssessmentSecureIndicator property
        private  _AssessmentSecureIndicator;

        // member variable for the FormNumber property
        private  _FormNumber;

        // member variable for the IntendedAdministrationEndDate property
        private  _IntendedAdministrationEndDate;

        // member variable for the IntendedAdministrationStartDate property
        private  _IntendedAdministrationStartDate;

        // member variable for the Name property
        private Guid? _Name;

        // member variable for the PlatformsSupported property
        private  _PlatformsSupported;

        // member variable for the PublishedDate property
        private  _PublishedDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentLanguageId property
        private  _RefAssessmentLanguageId;

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
        public  AccommodationList { get => _AccommodationList; set => SetProperty(ref _AccommodationList, value); }

        /// <summary>
        /// </summary>
        public  AssessmentFormAdaptiveIndicator { get => _AssessmentFormAdaptiveIndicator; set => SetProperty(ref _AssessmentFormAdaptiveIndicator, value); }

        /// <summary>
        /// </summary>
        public  AssessmentFormAlgorithmIdentifier { get => _AssessmentFormAlgorithmIdentifier; set => SetProperty(ref _AssessmentFormAlgorithmIdentifier, value); }

        /// <summary>
        /// </summary>
        public  AssessmentFormAlgorithmVersion { get => _AssessmentFormAlgorithmVersion; set => SetProperty(ref _AssessmentFormAlgorithmVersion, value); }

        /// <summary>
        /// </summary>
        public  AssessmentFormGUID { get => _AssessmentFormGUID; set => SetProperty(ref _AssessmentFormGUID, value); }

        /// <summary>
        /// </summary>
        public  AssessmentItemBankIdentifier { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        /// <summary>
        /// </summary>
        public  AssessmentItemBankName { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// </summary>
        public  AssessmentSecureIndicator { get => _AssessmentSecureIndicator; set => SetProperty(ref _AssessmentSecureIndicator, value); }

        /// <summary>
        /// </summary>
        public  FormNumber { get => _FormNumber; set => SetProperty(ref _FormNumber, value); }

        /// <summary>
        /// </summary>
        public  IntendedAdministrationEndDate { get => _IntendedAdministrationEndDate; set => SetProperty(ref _IntendedAdministrationEndDate, value); }

        /// <summary>
        /// </summary>
        public  IntendedAdministrationStartDate { get => _IntendedAdministrationStartDate; set => SetProperty(ref _IntendedAdministrationStartDate, value); }

        /// <summary>
        /// </summary>
        public Guid? Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  PlatformsSupported { get => _PlatformsSupported; set => SetProperty(ref _PlatformsSupported, value); }

        /// <summary>
        /// </summary>
        public  PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// </summary>
        public  RefAssessmentLanguageId { get => _RefAssessmentLanguageId; set => SetProperty(ref _RefAssessmentLanguageId, value); }

        /// <summary>
        /// </summary>
        public  Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentForm model)
        {
            IsBusy = true;
            Id = model.Id;
            AccommodationList = model.AccommodationList; // 
            AssessmentFormAdaptiveIndicator = model.AssessmentFormAdaptiveIndicator; // 
            AssessmentFormAlgorithmIdentifier = model.AssessmentFormAlgorithmIdentifier; // 
            AssessmentFormAlgorithmVersion = model.AssessmentFormAlgorithmVersion; // 
            AssessmentFormGUID = model.AssessmentFormGUID; // 
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier; // 
            AssessmentItemBankName = model.AssessmentItemBankName; // 
            AssessmentSecureIndicator = model.AssessmentSecureIndicator; // 
            FormNumber = model.FormNumber; // 
            IntendedAdministrationEndDate = model.IntendedAdministrationEndDate; // 
            IntendedAdministrationStartDate = model.IntendedAdministrationStartDate; // 
            Name = model.Name; // 
            PlatformsSupported = model.PlatformsSupported; // 
            PublishedDate = model.PublishedDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentLanguageId = model.RefAssessmentLanguageId; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
