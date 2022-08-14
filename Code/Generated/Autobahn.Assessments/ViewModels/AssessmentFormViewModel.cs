//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.String _AccommodationList;

        // member variable for the AssessmentFormAdaptiveIndicator property
        private System.Boolean? _AssessmentFormAdaptiveIndicator;

        // member variable for the AssessmentFormAlgorithmIdentifier property
        private System.String _AssessmentFormAlgorithmIdentifier;

        // member variable for the AssessmentFormAlgorithmVersion property
        private System.String _AssessmentFormAlgorithmVersion;

        // member variable for the AssessmentFormGUID property
        private System.String _AssessmentFormGUID;

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        // member variable for the AssessmentItemBankIdentifier property
        private System.String _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private System.String _AssessmentItemBankName;

        // member variable for the AssessmentSecureIndicator property
        private System.Boolean? _AssessmentSecureIndicator;

        // member variable for the FormNumber property
        private System.String _FormNumber;

        // member variable for the IntendedAdministrationEndDate property
        private System.DateTime? _IntendedAdministrationEndDate;

        // member variable for the IntendedAdministrationStartDate property
        private System.DateTime? _IntendedAdministrationStartDate;

        // member variable for the LearningResourceId property
        private Guid? _LearningResourceId;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the PlatformsSupported property
        private System.String _PlatformsSupported;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the RefAssessmentLanguageId property
        private Guid? _RefAssessmentLanguageId;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AccommodationList { get => _AccommodationList; set => SetProperty(ref _AccommodationList, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.Boolean? AssessmentFormAdaptiveIndicator { get => _AssessmentFormAdaptiveIndicator; set => SetProperty(ref _AssessmentFormAdaptiveIndicator, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentFormAlgorithmIdentifier { get => _AssessmentFormAlgorithmIdentifier; set => SetProperty(ref _AssessmentFormAlgorithmIdentifier, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentFormAlgorithmVersion { get => _AssessmentFormAlgorithmVersion; set => SetProperty(ref _AssessmentFormAlgorithmVersion, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentFormGUID { get => _AssessmentFormGUID; set => SetProperty(ref _AssessmentFormGUID, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Assessment"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentItemBankName { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.Boolean? AssessmentSecureIndicator { get => _AssessmentSecureIndicator; set => SetProperty(ref _AssessmentSecureIndicator, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String FormNumber { get => _FormNumber; set => SetProperty(ref _FormNumber, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.DateTime? IntendedAdministrationEndDate { get => _IntendedAdministrationEndDate; set => SetProperty(ref _IntendedAdministrationEndDate, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.DateTime? IntendedAdministrationStartDate { get => _IntendedAdministrationStartDate; set => SetProperty(ref _IntendedAdministrationStartDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String PlatformsSupported { get => _PlatformsSupported; set => SetProperty(ref _PlatformsSupported, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// </summary>
        public Guid? RefAssessmentLanguageId { get => _RefAssessmentLanguageId; set => SetProperty(ref _RefAssessmentLanguageId, value); }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentForm model)
        {
            IsBusy = true;
            Id = model.Id;
            AccommodationList = model.AccommodationList;
            AssessmentFormAdaptiveIndicator = model.AssessmentFormAdaptiveIndicator;
            AssessmentFormAlgorithmIdentifier = model.AssessmentFormAlgorithmIdentifier;
            AssessmentFormAlgorithmVersion = model.AssessmentFormAlgorithmVersion;
            AssessmentFormGUID = model.AssessmentFormGUID;
            AssessmentId = model.AssessmentId;
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier;
            AssessmentItemBankName = model.AssessmentItemBankName;
            AssessmentSecureIndicator = model.AssessmentSecureIndicator;
            FormNumber = model.FormNumber;
            IntendedAdministrationEndDate = model.IntendedAdministrationEndDate;
            IntendedAdministrationStartDate = model.IntendedAdministrationStartDate;
            LearningResourceId = model.LearningResourceId;
            Name = model.Name;
            PlatformsSupported = model.PlatformsSupported;
            PublishedDate = model.PublishedDate;
            RefAssessmentLanguageId = model.RefAssessmentLanguageId;
            Version = model.Version;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
