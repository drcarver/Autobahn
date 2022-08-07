//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonProgramParticipationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonProgramParticipationViewModel
     /// </summary>
    public partial class PersonProgramParticipationViewModel : ViewModelBase, Interfaces.IPersonProgramParticipationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonProgramParticipation";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefParticipationTypeId property
        private Guid? _RefParticipationTypeId;

        // member variable for the RefProgramExitReasonId property
        private Guid? _RefProgramExitReasonId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the ParticipationStatus property
        private System.String _ParticipationStatus;

        // member variable for the RefProgramEntryReasonId property
        private Guid? _RefProgramEntryReasonId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonProgramParticipationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationTypeId"/> model
        /// </summary>
        public Guid? RefParticipationTypeId { get => _RefParticipationTypeId; set => SetProperty(ref _RefParticipationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramExitReasonId"/> model
        /// </summary>
        public Guid? RefProgramExitReasonId { get => _RefProgramExitReasonId; set => SetProperty(ref _RefProgramExitReasonId, value); }

        public System.String ParticipationStatus  { get => _ParticipationStatus; set => SetProperty(ref _ParticipationStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramEntryReasonId"/> model
        /// </summary>
        public Guid? RefProgramEntryReasonId { get => _RefProgramEntryReasonId; set => SetProperty(ref _RefProgramEntryReasonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonProgramParticipation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefParticipationTypeId = model.RefParticipationTypeId;
            RefProgramExitReasonId = model.RefProgramExitReasonId;
            ParticipationStatus = model.ParticipationStatus;
            RefProgramEntryReasonId = model.RefProgramEntryReasonId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
