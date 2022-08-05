//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramMeetingAttendeeViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
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
        /// The title of the IndividualizedProgramMeetingAttendeeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramMeetingId"/> model
        /// </summary>
        public Guid IndividualizedProgramMeetingId { get => _IndividualizedProgramMeetingId; set => SetProperty(ref _IndividualizedProgramMeetingId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
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
