//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationSpecialEducationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationSpecialEducationViewModel
     /// </summary>
    public partial class ProgramParticipationSpecialEducationViewModel : ViewModelBase, Interfaces.IProgramParticipationSpecialEducationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationSpecialEducation";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the AwaitingInitialIDEAEvaluationStatus property
        private System.Boolean? _AwaitingInitialIDEAEvaluationStatus;

        // member variable for the SpecialEducationFTE property
        private System.Decimal? _SpecialEducationFTE;

        // member variable for the SpecialEducationServicesExitDate property
        private System.DateTime? _SpecialEducationServicesExitDate;

        // member variable for the IDEAPlacementRationale property
        private System.String _IDEAPlacementRationale;

        // member variable for the RefIDEAEducationalEnvironmentECId property
        private Guid? _RefIDEAEducationalEnvironmentECId;

        // member variable for the RefIDEAEducationalEnvironmentSchoolAgeId property
        private Guid? _RefIDEAEducationalEnvironmentSchoolAgeId;

        // member variable for the RefSpecialEducationExitReasonId property
        private Guid? _RefSpecialEducationExitReasonId;

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
        /// The title of the ProgramParticipationSpecialEducationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        public System.Boolean? AwaitingInitialIDEAEvaluationStatus { get => _AwaitingInitialIDEAEvaluationStatus; set => SetProperty(ref _AwaitingInitialIDEAEvaluationStatus, value); }

        public System.Decimal? SpecialEducationFTE { get => _SpecialEducationFTE; set => SetProperty(ref _SpecialEducationFTE, value); }

        public System.DateTime? SpecialEducationServicesExitDate { get => _SpecialEducationServicesExitDate; set => SetProperty(ref _SpecialEducationServicesExitDate, value); }

        public System.String IDEAPlacementRationale  { get => _IDEAPlacementRationale; set => SetProperty(ref _IDEAPlacementRationale, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentECId"/> model
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentECId { get => _RefIDEAEducationalEnvironmentECId; set => SetProperty(ref _RefIDEAEducationalEnvironmentECId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEducationalEnvironmentSchoolAgeId"/> model
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get => _RefIDEAEducationalEnvironmentSchoolAgeId; set => SetProperty(ref _RefIDEAEducationalEnvironmentSchoolAgeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationExitReasonId"/> model
        /// </summary>
        public Guid? RefSpecialEducationExitReasonId { get => _RefSpecialEducationExitReasonId; set => SetProperty(ref _RefSpecialEducationExitReasonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationSpecialEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            AwaitingInitialIDEAEvaluationStatus = model.AwaitingInitialIDEAEvaluationStatus;
            SpecialEducationFTE = model.SpecialEducationFTE;
            SpecialEducationServicesExitDate = model.SpecialEducationServicesExitDate;
            IDEAPlacementRationale = model.IDEAPlacementRationale;
            RefIDEAEducationalEnvironmentECId = model.RefIDEAEducationalEnvironmentECId;
            RefIDEAEducationalEnvironmentSchoolAgeId = model.RefIDEAEducationalEnvironmentSchoolAgeId;
            RefSpecialEducationExitReasonId = model.RefSpecialEducationExitReasonId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
