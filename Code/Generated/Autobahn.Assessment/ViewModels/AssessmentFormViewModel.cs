//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentFormViewModel
     /// </summary>
    public partial class AssessmentFormViewModel : ViewModelBase, Interfaces.IAssessmentForm
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentForm";

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        // member variable for the FormNumber property
        private System.String _FormNumber;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the Version property
        private System.String _Version;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the AccommodationList property
        private System.String _AccommodationList;

        // member variable for the IntendedAdministrationStartDate property
        private System.DateTime? _IntendedAdministrationStartDate;

        // member variable for the IntendedAdministrationEndDate property
        private System.DateTime? _IntendedAdministrationEndDate;

        // member variable for the AssessmentItemBankIdentifier property
        private System.String _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private System.String _AssessmentItemBankName;

        // member variable for the PlatformsSupported property
        private System.String _PlatformsSupported;

        // member variable for the RefAssessmentLanguageId property
        private Guid? _RefAssessmentLanguageId;

        // member variable for the AssessmentSecureIndicator property
        private System.Boolean? _AssessmentSecureIndicator;

        // member variable for the LearningResourceId property
        private Guid? _LearningResourceId;

        // member variable for the AssessmentFormAdaptiveIndicator property
        private System.Boolean? _AssessmentFormAdaptiveIndicator;

        // member variable for the AssessmentFormAlgorithmIdentifier property
        private System.String _AssessmentFormAlgorithmIdentifier;

        // member variable for the AssessmentFormAlgorithmVersion property
        private System.String _AssessmentFormAlgorithmVersion;

        // member variable for the AssessmentFormGUID property
        private System.String _AssessmentFormGUID;

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
        /// The title of the AssessmentFormViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentId"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        public System.String FormNumber  { get => _FormNumber; set => SetProperty(ref _FormNumber, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        public System.String AccommodationList  { get => _AccommodationList; set => SetProperty(ref _AccommodationList, value); }

        public System.DateTime? IntendedAdministrationStartDate { get => _IntendedAdministrationStartDate; set => SetProperty(ref _IntendedAdministrationStartDate, value); }

        public System.DateTime? IntendedAdministrationEndDate { get => _IntendedAdministrationEndDate; set => SetProperty(ref _IntendedAdministrationEndDate, value); }

        public System.String AssessmentItemBankIdentifier  { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        public System.String AssessmentItemBankName  { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        public System.String PlatformsSupported  { get => _PlatformsSupported; set => SetProperty(ref _PlatformsSupported, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguageId"/> model
        /// </summary>
        public Guid? RefAssessmentLanguageId { get => _RefAssessmentLanguageId; set => SetProperty(ref _RefAssessmentLanguageId, value); }

        public System.Boolean? AssessmentSecureIndicator { get => _AssessmentSecureIndicator; set => SetProperty(ref _AssessmentSecureIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid? LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        public System.Boolean? AssessmentFormAdaptiveIndicator { get => _AssessmentFormAdaptiveIndicator; set => SetProperty(ref _AssessmentFormAdaptiveIndicator, value); }

        public System.String AssessmentFormAlgorithmIdentifier  { get => _AssessmentFormAlgorithmIdentifier; set => SetProperty(ref _AssessmentFormAlgorithmIdentifier, value); }

        public System.String AssessmentFormAlgorithmVersion  { get => _AssessmentFormAlgorithmVersion; set => SetProperty(ref _AssessmentFormAlgorithmVersion, value); }

        public System.String AssessmentFormGUID  { get => _AssessmentFormGUID; set => SetProperty(ref _AssessmentFormGUID, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentForm model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            FormNumber = model.FormNumber;
            Name = model.Name;
            Version = model.Version;
            PublishedDate = model.PublishedDate;
            AccommodationList = model.AccommodationList;
            IntendedAdministrationStartDate = model.IntendedAdministrationStartDate;
            IntendedAdministrationEndDate = model.IntendedAdministrationEndDate;
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier;
            AssessmentItemBankName = model.AssessmentItemBankName;
            PlatformsSupported = model.PlatformsSupported;
            RefAssessmentLanguageId = model.RefAssessmentLanguageId;
            AssessmentSecureIndicator = model.AssessmentSecureIndicator;
            LearningResourceId = model.LearningResourceId;
            AssessmentFormAdaptiveIndicator = model.AssessmentFormAdaptiveIndicator;
            AssessmentFormAlgorithmIdentifier = model.AssessmentFormAlgorithmIdentifier;
            AssessmentFormAlgorithmVersion = model.AssessmentFormAlgorithmVersion;
            AssessmentFormGUID = model.AssessmentFormGUID;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
