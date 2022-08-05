//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationAttainmentViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationAttainmentViewModel
     /// </summary>
    public partial class ProgramParticipationAttainmentViewModel : ViewModelBase, Interfaces.IProgramParticipationAttainment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationAttainment";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the AECredentialAttainmentEmployedIndicator property
        private System.Boolean? _AECredentialAttainmentEmployedIndicator;

        // member variable for the AECredentialAttainmentPSCredentialIndicator property
        private System.Boolean? _AECredentialAttainmentPSCredentialIndicator;

        // member variable for the AECredentialAttainmentPSEnrollmentIndicator property
        private System.Boolean? _AECredentialAttainmentPSEnrollmentIndicator;

        // member variable for the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId property
        private Guid? _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId;

        // member variable for the RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId property
        private Guid? _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId;

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
        /// The title of the ProgramParticipationAttainmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        public System.Boolean? AECredentialAttainmentEmployedIndicator { get => _AECredentialAttainmentEmployedIndicator; set => SetProperty(ref _AECredentialAttainmentEmployedIndicator, value); }

        public System.Boolean? AECredentialAttainmentPSCredentialIndicator { get => _AECredentialAttainmentPSCredentialIndicator; set => SetProperty(ref _AECredentialAttainmentPSCredentialIndicator, value); }

        public System.Boolean? AECredentialAttainmentPSEnrollmentIndicator { get => _AECredentialAttainmentPSEnrollmentIndicator; set => SetProperty(ref _AECredentialAttainmentPSEnrollmentIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId"/> model
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get => _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId; set => SetProperty(ref _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId"/> model
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get => _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId; set => SetProperty(ref _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationAttainment model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            AECredentialAttainmentEmployedIndicator = model.AECredentialAttainmentEmployedIndicator;
            AECredentialAttainmentPSCredentialIndicator = model.AECredentialAttainmentPSCredentialIndicator;
            AECredentialAttainmentPSEnrollmentIndicator = model.AECredentialAttainmentPSEnrollmentIndicator;
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId;
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
