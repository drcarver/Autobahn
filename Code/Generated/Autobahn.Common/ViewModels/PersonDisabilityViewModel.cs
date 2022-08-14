//**********************************************************
//* DomainName: Common Models
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

        // member variable for the DisabilityStatus property
        private System.Boolean? _DisabilityStatus;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PrimaryDisabilityTypeId property
        private Guid? _PrimaryDisabilityTypeId;

        // member variable for the RefAccommodationsNeededTypeId property
        private Guid? _RefAccommodationsNeededTypeId;

        // member variable for the RefDisabilityConditionStatusCodeId property
        private Guid? _RefDisabilityConditionStatusCodeId;

        // member variable for the RefDisabilityConditionTypeId property
        private Guid? _RefDisabilityConditionTypeId;

        // member variable for the RefDisabilityDeterminationSourceTypeId property
        private Guid? _RefDisabilityDeterminationSourceTypeId;

        // member variable for the RefIDEADisabilityTypeId property
        private Guid? _RefIDEADisabilityTypeId;

        // member variable for the SignificantCognitiveDisabilityIndicator property
        private System.Boolean? _SignificantCognitiveDisabilityIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDisabilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public System.Boolean? DisabilityStatus { get => _DisabilityStatus; set => SetProperty(ref _DisabilityStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PrimaryDisabilityType"/> model
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get => _PrimaryDisabilityTypeId; set => SetProperty(ref _PrimaryDisabilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationsNeededType"/> model
        /// </summary>
        public Guid? RefAccommodationsNeededTypeId { get => _RefAccommodationsNeededTypeId; set => SetProperty(ref _RefAccommodationsNeededTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionStatusCode"/> model
        /// </summary>
        public Guid? RefDisabilityConditionStatusCodeId { get => _RefDisabilityConditionStatusCodeId; set => SetProperty(ref _RefDisabilityConditionStatusCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionType"/> model
        /// </summary>
        public Guid? RefDisabilityConditionTypeId { get => _RefDisabilityConditionTypeId; set => SetProperty(ref _RefDisabilityConditionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityDeterminationSourceType"/> model
        /// </summary>
        public Guid? RefDisabilityDeterminationSourceTypeId { get => _RefDisabilityDeterminationSourceTypeId; set => SetProperty(ref _RefDisabilityDeterminationSourceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisabilityType"/> model
        /// </summary>
        public Guid? RefIDEADisabilityTypeId { get => _RefIDEADisabilityTypeId; set => SetProperty(ref _RefIDEADisabilityTypeId, value); }

        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public System.Boolean? SignificantCognitiveDisabilityIndicator { get => _SignificantCognitiveDisabilityIndicator; set => SetProperty(ref _SignificantCognitiveDisabilityIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDisability model)
        {
            IsBusy = true;
            Id = model.Id;
            DisabilityStatus = model.DisabilityStatus;
            PersonId = model.PersonId;
            PrimaryDisabilityTypeId = model.PrimaryDisabilityTypeId;
            RefAccommodationsNeededTypeId = model.RefAccommodationsNeededTypeId;
            RefDisabilityConditionStatusCodeId = model.RefDisabilityConditionStatusCodeId;
            RefDisabilityConditionTypeId = model.RefDisabilityConditionTypeId;
            RefDisabilityDeterminationSourceTypeId = model.RefDisabilityDeterminationSourceTypeId;
            RefIDEADisabilityTypeId = model.RefIDEADisabilityTypeId;
            SignificantCognitiveDisabilityIndicator = model.SignificantCognitiveDisabilityIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
