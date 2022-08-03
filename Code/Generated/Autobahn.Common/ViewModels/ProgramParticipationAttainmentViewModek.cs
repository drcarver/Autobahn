//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationAttainmentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationAttainmentViewModel
     /// </summary>
    public partial class ProgramParticipationAttainmentViewModel : BindableBase, IProgramParticipationAttainment
    {
#region "Backing Fields"
        // member variable for the AECredentialAttainmentEmployedIndicator property
        private System.Boolean? _AECredentialAttainmentEmployedIndicator;

        // member variable for the AECredentialAttainmentPSCredentialIndicator property
        private System.Boolean? _AECredentialAttainmentPSCredentialIndicator;

        // member variable for the AECredentialAttainmentPSEnrollmentIndicator property
        private System.Boolean? _AECredentialAttainmentPSEnrollmentIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        public System.Boolean? AECredentialAttainmentEmployedIndicator { get => _AECredentialAttainmentEmployedIndicator; set => SetProperty(ref _AECredentialAttainmentEmployedIndicator, value); }

        public System.Boolean? AECredentialAttainmentPSCredentialIndicator { get => _AECredentialAttainmentPSCredentialIndicator; set => SetProperty(ref _AECredentialAttainmentPSCredentialIndicator, value); }

        public System.Boolean? AECredentialAttainmentPSEnrollmentIndicator { get => _AECredentialAttainmentPSEnrollmentIndicator; set => SetProperty(ref _AECredentialAttainmentPSEnrollmentIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId"/> model
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId"/> model
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get; set; }

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
        public void Load(IProgramParticipationAttainment model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            AECredentialAttainmentEmployedIndicator = model.AECredentialAttainmentEmployedIndicator;
            AECredentialAttainmentPSCredentialIndicator = model.AECredentialAttainmentPSCredentialIndicator;
            AECredentialAttainmentPSEnrollmentIndicator = model.AECredentialAttainmentPSEnrollmentIndicator;
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId;
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId;
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
