//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramMeetingAttendeeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramMeetingAttendeeViewModel
     /// </summary>
    public partial class IndividualizedProgramMeetingAttendeeViewModel : ViewModelBase, Interfaces.IIndividualizedProgramMeetingAttendee
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramMeetingAttendee";

        // member variable for the IndividualizedProgramMeetingId property
        private Guid _IndividualizedProgramMeetingId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramMeetingAttendeeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgramMeeting"/> model
        /// </summary>
        public Guid IndividualizedProgramMeetingId { get => _IndividualizedProgramMeetingId; set => SetProperty(ref _IndividualizedProgramMeetingId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramMeetingAttendee model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramMeetingId = model.IndividualizedProgramMeetingId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
