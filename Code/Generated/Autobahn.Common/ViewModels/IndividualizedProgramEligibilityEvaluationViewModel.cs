//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramEligibilityEvaluationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluationViewModel
     /// </summary>
    public partial class IndividualizedProgramEligibilityEvaluationViewModel : ViewModelBase, Interfaces.IIndividualizedProgramEligibilityEvaluationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramEligibilityEvaluation";

        // member variable for the EligibilityEvaluationId property
        private Guid _EligibilityEvaluationId;

        // member variable for the IndividualizedProgramEligibilityId property
        private Guid _IndividualizedProgramEligibilityId;

        // member variable for the RefIEPEligibilityEvaluationTypeId property
        private Guid? _RefIEPEligibilityEvaluationTypeId;

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
        /// The title of the IndividualizedProgramEligibilityEvaluationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="EligibilityEvaluationId"/> model
        /// </summary>
        public Guid EligibilityEvaluationId { get => _EligibilityEvaluationId; set => SetProperty(ref _EligibilityEvaluationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramEligibilityId"/> model
        /// </summary>
        public Guid IndividualizedProgramEligibilityId { get => _IndividualizedProgramEligibilityId; set => SetProperty(ref _IndividualizedProgramEligibilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPEligibilityEvaluationTypeId"/> model
        /// </summary>
        public Guid? RefIEPEligibilityEvaluationTypeId { get => _RefIEPEligibilityEvaluationTypeId; set => SetProperty(ref _RefIEPEligibilityEvaluationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramEligibilityEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            EligibilityEvaluationId = model.EligibilityEvaluationId;
            IndividualizedProgramEligibilityId = model.IndividualizedProgramEligibilityId;
            RefIEPEligibilityEvaluationTypeId = model.RefIEPEligibilityEvaluationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
