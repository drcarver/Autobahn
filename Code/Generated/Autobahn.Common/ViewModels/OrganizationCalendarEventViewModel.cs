//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarEventViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarEventViewModel
     /// </summary>
    public partial class OrganizationCalendarEventViewModel : ViewModelBase, Interfaces.IOrganizationCalendarEventViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarEvent";

        // member variable for the OrganizationCalendarId property
        private Guid _OrganizationCalendarId;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the EventDate property
        private System.DateTime _EventDate;

        // member variable for the RefCalendarEventType property
        private System.Int32? _RefCalendarEventType;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        // member variable for the EndTime property
        private System.TimeSpan? _EndTime;

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
        /// The title of the OrganizationCalendarEventViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarId"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get => _OrganizationCalendarId; set => SetProperty(ref _OrganizationCalendarId, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.DateTime EventDate  { get => _EventDate; set => SetProperty(ref _EventDate, value); }

        public System.Int32? RefCalendarEventType { get => _RefCalendarEventType; set => SetProperty(ref _RefCalendarEventType, value); }

        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        public System.TimeSpan? EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationCalendarId = model.OrganizationCalendarId;
            Name = model.Name;
            EventDate = model.EventDate;
            RefCalendarEventType = model.RefCalendarEventType;
            StartTime = model.StartTime;
            EndTime = model.EndTime;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
