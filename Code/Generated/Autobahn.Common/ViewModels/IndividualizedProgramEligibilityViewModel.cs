//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramEligibilityViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramEligibilityViewModel
     /// </summary>
    public partial class IndividualizedProgramEligibilityViewModel : ViewModelBase, Interfaces.IIndividualizedProgramEligibilityViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramEligibility";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the ConsentToEvaluateDate property
        private System.DateTime? _ConsentToEvaluateDate;

        // member variable for the ConsentToEvaluateIndicator property
        private System.Boolean? _ConsentToEvaluateIndicator;

        // member variable for the ParentObservations property
        private System.String _ParentObservations;

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
        /// The title of the IndividualizedProgramEligibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        public System.DateTime? ConsentToEvaluateDate { get => _ConsentToEvaluateDate; set => SetProperty(ref _ConsentToEvaluateDate, value); }

        public System.Boolean? ConsentToEvaluateIndicator { get => _ConsentToEvaluateIndicator; set => SetProperty(ref _ConsentToEvaluateIndicator, value); }

        public System.String ParentObservations  { get => _ParentObservations; set => SetProperty(ref _ParentObservations, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            ConsentToEvaluateDate = model.ConsentToEvaluateDate;
            ConsentToEvaluateIndicator = model.ConsentToEvaluateIndicator;
            ParentObservations = model.ParentObservations;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
