//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarEventViewModel
     /// </summary>
    public partial class OrganizationCalendarEventViewModel : ViewModelBase, Interfaces.IOrganizationCalendarEvent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarEvent";

        // member variable for the EndTime property
        private System.TimeSpan? _EndTime;

        // member variable for the EventDate property
        private System.DateTime _EventDate;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the OrganizationCalendarId property
        private Guid _OrganizationCalendarId;

        // member variable for the RefCalendarEventType property
        private System.Int32? _RefCalendarEventType;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarEventViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        public System.TimeSpan? EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        public System.DateTime EventDate { get => _EventDate; set => SetProperty(ref _EventDate, value); }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get => _OrganizationCalendarId; set => SetProperty(ref _OrganizationCalendarId, value); }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        public System.Int32? RefCalendarEventType { get => _RefCalendarEventType; set => SetProperty(ref _RefCalendarEventType, value); }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            EndTime = model.EndTime;
            EventDate = model.EventDate;
            Name = model.Name;
            OrganizationCalendarId = model.OrganizationCalendarId;
            RefCalendarEventType = model.RefCalendarEventType;
            StartTime = model.StartTime;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
