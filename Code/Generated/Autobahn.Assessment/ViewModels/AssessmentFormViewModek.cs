//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentFormViewModel
     /// </summary>
    public partial class AssessmentFormViewModel : BindableBase, IAssessmentForm
    {
#region "Backing Fields"
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

        // member variable for the AssessmentSecureIndicator property
        private System.Boolean? _AssessmentSecureIndicator;

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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentId"/> model
        /// </summary>
        public Guid AssessmentId { get; set; }

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
        public Guid? RefAssessmentLanguageId { get; set; }

        public System.Boolean? AssessmentSecureIndicator { get => _AssessmentSecureIndicator; set => SetProperty(ref _AssessmentSecureIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        public System.Boolean? AssessmentFormAdaptiveIndicator { get => _AssessmentFormAdaptiveIndicator; set => SetProperty(ref _AssessmentFormAdaptiveIndicator, value); }

        public System.String AssessmentFormAlgorithmIdentifier  { get => _AssessmentFormAlgorithmIdentifier; set => SetProperty(ref _AssessmentFormAlgorithmIdentifier, value); }

        public System.String AssessmentFormAlgorithmVersion  { get => _AssessmentFormAlgorithmVersion; set => SetProperty(ref _AssessmentFormAlgorithmVersion, value); }

        public System.String AssessmentFormGUID  { get => _AssessmentFormGUID; set => SetProperty(ref _AssessmentFormGUID, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentForm model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
