//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonProgramParticipationViewModel
     /// </summary>
    public partial class PersonProgramParticipationViewModel : ViewModelBase, Interfaces.IPersonProgramParticipation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonProgramParticipation";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ParticipationStatus property
        private System.String _ParticipationStatus;

        // member variable for the RefParticipationTypeId property
        private Guid? _RefParticipationTypeId;

        // member variable for the RefProgramEntryReasonId property
        private Guid? _RefProgramEntryReasonId;

        // member variable for the RefProgramExitReasonId property
        private Guid? _RefProgramExitReasonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonProgramParticipationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </summary>
        public System.String ParticipationStatus { get => _ParticipationStatus; set => SetProperty(ref _ParticipationStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationType"/> model
        /// </summary>
        public Guid? RefParticipationTypeId { get => _RefParticipationTypeId; set => SetProperty(ref _RefParticipationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramEntryReason"/> model
        /// </summary>
        public Guid? RefProgramEntryReasonId { get => _RefProgramEntryReasonId; set => SetProperty(ref _RefProgramEntryReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramExitReason"/> model
        /// </summary>
        public Guid? RefProgramExitReasonId { get => _RefProgramExitReasonId; set => SetProperty(ref _RefProgramExitReasonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonProgramParticipation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ParticipationStatus = model.ParticipationStatus;
            RefParticipationTypeId = model.RefParticipationTypeId;
            RefProgramEntryReasonId = model.RefProgramEntryReasonId;
            RefProgramExitReasonId = model.RefProgramExitReasonId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
