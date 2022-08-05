//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDisabilityViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDisabilityViewModel
     /// </summary>
    public partial class PersonDisabilityViewModel : ViewModelBase, Interfaces.IPersonDisability
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDisability";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PrimaryDisabilityTypeId property
        private Guid? _PrimaryDisabilityTypeId;

        // member variable for the DisabilityStatus property
        private System.Boolean? _DisabilityStatus;

        // member variable for the RefAccommodationsNeededTypeId property
        private Guid? _RefAccommodationsNeededTypeId;

        // member variable for the RefDisabilityConditionTypeId property
        private Guid? _RefDisabilityConditionTypeId;

        // member variable for the RefDisabilityDeterminationSourceTypeId property
        private Guid? _RefDisabilityDeterminationSourceTypeId;

        // member variable for the RefDisabilityConditionStatusCodeId property
        private Guid? _RefDisabilityConditionStatusCodeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the SignificantCognitiveDisabilityIndicator property
        private System.Boolean? _SignificantCognitiveDisabilityIndicator;

        // member variable for the RefIDEADisabilityTypeId property
        private Guid? _RefIDEADisabilityTypeId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDisabilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PrimaryDisabilityTypeId"/> model
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get => _PrimaryDisabilityTypeId; set => SetProperty(ref _PrimaryDisabilityTypeId, value); }

        public System.Boolean? DisabilityStatus { get => _DisabilityStatus; set => SetProperty(ref _DisabilityStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationsNeededTypeId"/> model
        /// </summary>
        public Guid? RefAccommodationsNeededTypeId { get => _RefAccommodationsNeededTypeId; set => SetProperty(ref _RefAccommodationsNeededTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionTypeId"/> model
        /// </summary>
        public Guid? RefDisabilityConditionTypeId { get => _RefDisabilityConditionTypeId; set => SetProperty(ref _RefDisabilityConditionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityDeterminationSourceTypeId"/> model
        /// </summary>
        public Guid? RefDisabilityDeterminationSourceTypeId { get => _RefDisabilityDeterminationSourceTypeId; set => SetProperty(ref _RefDisabilityDeterminationSourceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionStatusCodeId"/> model
        /// </summary>
        public Guid? RefDisabilityConditionStatusCodeId { get => _RefDisabilityConditionStatusCodeId; set => SetProperty(ref _RefDisabilityConditionStatusCodeId, value); }

        public System.Boolean? SignificantCognitiveDisabilityIndicator { get => _SignificantCognitiveDisabilityIndicator; set => SetProperty(ref _SignificantCognitiveDisabilityIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisabilityTypeId"/> model
        /// </summary>
        public Guid? RefIDEADisabilityTypeId { get => _RefIDEADisabilityTypeId; set => SetProperty(ref _RefIDEADisabilityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDisability model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            PrimaryDisabilityTypeId = model.PrimaryDisabilityTypeId;
            DisabilityStatus = model.DisabilityStatus;
            RefAccommodationsNeededTypeId = model.RefAccommodationsNeededTypeId;
            RefDisabilityConditionTypeId = model.RefDisabilityConditionTypeId;
            RefDisabilityDeterminationSourceTypeId = model.RefDisabilityDeterminationSourceTypeId;
            RefDisabilityConditionStatusCodeId = model.RefDisabilityConditionStatusCodeId;
            SignificantCognitiveDisabilityIndicator = model.SignificantCognitiveDisabilityIndicator;
            RefIDEADisabilityTypeId = model.RefIDEADisabilityTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
