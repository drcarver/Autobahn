//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   WorkforceProgramParticipationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceProgramParticipationViewModel
     /// </summary>
    public partial class WorkforceProgramParticipationViewModel : ViewModelBase, Interfaces.IWorkforceProgramParticipation
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceProgramParticipation";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the DiplomaOrCredentialAwardDate property
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the RefWfProgramParticipationId property
        private Guid? _RefWfProgramParticipationId;

        // member variable for the RefProfessionalTechnicalCredentialTypeId property
        private Guid? _RefProfessionalTechnicalCredentialTypeId;

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
        /// The title of the WorkforceProgramParticipationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        public System.String DiplomaOrCredentialAwardDate  { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWfProgramParticipationId"/> model
        /// </summary>
        public Guid? RefWfProgramParticipationId { get => _RefWfProgramParticipationId; set => SetProperty(ref _RefWfProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialTypeId"/> model
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get => _RefProfessionalTechnicalCredentialTypeId; set => SetProperty(ref _RefProfessionalTechnicalCredentialTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceProgramParticipation model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate;
            RefWfProgramParticipationId = model.RefWfProgramParticipationId;
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
