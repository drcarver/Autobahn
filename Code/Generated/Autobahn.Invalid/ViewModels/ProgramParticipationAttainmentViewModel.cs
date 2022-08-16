//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationAttainmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationAttainmentViewModel
     /// </summary>
    public partial class ProgramParticipationAttainmentViewModel : ViewModelBase, Interfaces.IProgramParticipationAttainment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationAttainment";

        // member variable for the AECredentialAttainmentEmployedIndicator property
        private  _AECredentialAttainmentEmployedIndicator;

        // member variable for the AECredentialAttainmentPSCredentialIndicator property
        private  _AECredentialAttainmentPSCredentialIndicator;

        // member variable for the AECredentialAttainmentPSEnrollmentIndicator property
        private  _AECredentialAttainmentPSEnrollmentIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        // member variable for the RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId property
        private  _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId;

        // member variable for the RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId property
        private  _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AECredentialAttainmentEmployedIndicator { get => _AECredentialAttainmentEmployedIndicator; set => SetProperty(ref _AECredentialAttainmentEmployedIndicator, value); }

        /// <summary>
        /// </summary>
        public  AECredentialAttainmentPSCredentialIndicator { get => _AECredentialAttainmentPSCredentialIndicator; set => SetProperty(ref _AECredentialAttainmentPSCredentialIndicator, value); }

        /// <summary>
        /// </summary>
        public  AECredentialAttainmentPSEnrollmentIndicator { get => _AECredentialAttainmentPSEnrollmentIndicator; set => SetProperty(ref _AECredentialAttainmentPSEnrollmentIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitType"/> model
        /// </summary>
        public  RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get => _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId; set => SetProperty(ref _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeType"/> model
        /// </summary>
        public  RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get => _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId; set => SetProperty(ref _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationAttainment model)
        {
            IsBusy = true;
            Id = model.Id;
            AECredentialAttainmentEmployedIndicator = model.AECredentialAttainmentEmployedIndicator; // 
            AECredentialAttainmentPSCredentialIndicator = model.AECredentialAttainmentPSCredentialIndicator; // 
            AECredentialAttainmentPSEnrollmentIndicator = model.AECredentialAttainmentPSEnrollmentIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId; // 
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
