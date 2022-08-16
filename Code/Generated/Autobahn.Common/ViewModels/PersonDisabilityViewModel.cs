//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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
        private  _DisabilityStatus;

        // member variable for the PrimaryDisabilityTypeId property
        private Guid? _PrimaryDisabilityTypeId;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAccommodationsNeededTypeId property
        private  _RefAccommodationsNeededTypeId;

        // member variable for the RefDisabilityConditionStatusCodeId property
        private  _RefDisabilityConditionStatusCodeId;

        // member variable for the RefDisabilityConditionTypeId property
        private  _RefDisabilityConditionTypeId;

        // member variable for the RefDisabilityDeterminationSourceTypeId property
        private  _RefDisabilityDeterminationSourceTypeId;

        // member variable for the RefIDEADisabilityTypeId property
        private  _RefIDEADisabilityTypeId;

        // member variable for the SignificantCognitiveDisabilityIndicator property
        private  _SignificantCognitiveDisabilityIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DisabilityStatus { get => _DisabilityStatus; set => SetProperty(ref _DisabilityStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PrimaryDisabilityType"/> model
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get => _PrimaryDisabilityTypeId; set => SetProperty(ref _PrimaryDisabilityTypeId, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationsNeededType"/> model
        /// </summary>
        public  RefAccommodationsNeededTypeId { get => _RefAccommodationsNeededTypeId; set => SetProperty(ref _RefAccommodationsNeededTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionStatusCode"/> model
        /// </summary>
        public  RefDisabilityConditionStatusCodeId { get => _RefDisabilityConditionStatusCodeId; set => SetProperty(ref _RefDisabilityConditionStatusCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionType"/> model
        /// </summary>
        public  RefDisabilityConditionTypeId { get => _RefDisabilityConditionTypeId; set => SetProperty(ref _RefDisabilityConditionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityDeterminationSourceType"/> model
        /// </summary>
        public  RefDisabilityDeterminationSourceTypeId { get => _RefDisabilityDeterminationSourceTypeId; set => SetProperty(ref _RefDisabilityDeterminationSourceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisabilityType"/> model
        /// </summary>
        public  RefIDEADisabilityTypeId { get => _RefIDEADisabilityTypeId; set => SetProperty(ref _RefIDEADisabilityTypeId, value); }

        /// <summary>
        /// </summary>
        public  SignificantCognitiveDisabilityIndicator { get => _SignificantCognitiveDisabilityIndicator; set => SetProperty(ref _SignificantCognitiveDisabilityIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDisability model)
        {
            IsBusy = true;
            Id = model.Id;
            DisabilityStatus = model.DisabilityStatus; // 
            PrimaryDisabilityTypeId = model.PrimaryDisabilityTypeId; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAccommodationsNeededTypeId = model.RefAccommodationsNeededTypeId; // 
            RefDisabilityConditionStatusCodeId = model.RefDisabilityConditionStatusCodeId; // 
            RefDisabilityConditionTypeId = model.RefDisabilityConditionTypeId; // 
            RefDisabilityDeterminationSourceTypeId = model.RefDisabilityDeterminationSourceTypeId; // 
            RefIDEADisabilityTypeId = model.RefIDEADisabilityTypeId; // 
            SignificantCognitiveDisabilityIndicator = model.SignificantCognitiveDisabilityIndicator; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
