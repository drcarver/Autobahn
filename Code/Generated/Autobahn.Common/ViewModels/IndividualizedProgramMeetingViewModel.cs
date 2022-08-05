//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramMeetingViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramMeetingViewModel
     /// </summary>
    public partial class IndividualizedProgramMeetingViewModel : ViewModelBase, Interfaces.IIndividualizedProgramMeeting
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramMeeting";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the MeetingDate property
        private System.DateTime? _MeetingDate;

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
        /// The title of the IndividualizedProgramMeetingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        public System.DateTime? MeetingDate { get => _MeetingDate; set => SetProperty(ref _MeetingDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramMeeting model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            MeetingDate = model.MeetingDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
