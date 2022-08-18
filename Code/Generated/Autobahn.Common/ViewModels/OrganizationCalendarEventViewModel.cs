//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarEvent View Model
     /// </summary>
    public partial class OrganizationCalendarEventViewModel : ViewModelBase, Interfaces.IOrganizationCalendarEvent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarEvent";

        // EndTime -- (backing property for End Time)
        private System.TimeSpan? _EndTime;

        // EventDate -- (backing property for Calendar Event Date)
        private System.DateTime _EventDate;

        // Name -- (backing property for Calendar Event Day Name)
        private System.String _Name;

        // member variable for the OrganizationCalendarId property
        private Guid _OrganizationCalendarId;

        // RefCalendarEventType -- (backing property for Calendar Event Type)
        private System.Int32? _RefCalendarEventType;

        // StartTime -- (backing property for Start Time)
        private System.TimeSpan? _StartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// End Time
        /// <para>
        /// The ending hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// Calendar Event Date
        /// <para>
        /// The date of the scheduled or unscheduled calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20241">Calendar Event Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime EventDate { get => _EventDate; set => SetProperty(ref _EventDate, value); }

        /// <summary>
        /// Calendar Event Day Name
        /// <para>
        /// A name used for the day of the calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20242">Calendar Event Day Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get => _OrganizationCalendarId; set => SetProperty(ref _OrganizationCalendarId, value); }

        /// <summary>
        /// Calendar Event Type
        /// <para>
        /// A type of scheduled or unscheduled calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19596">Calendar Event Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? RefCalendarEventType { get => _RefCalendarEventType; set => SetProperty(ref _RefCalendarEventType, value); }

        /// <summary>
        /// Start Time
        /// <para>
        /// The starting hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
        /// </para>
        /// </summary>
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
            EndTime = model.EndTime; // End Time
            EventDate = model.EventDate; // Calendar Event Date
            Name = model.Name; // Calendar Event Day Name
            OrganizationCalendarId = model.OrganizationCalendarId; // 
            RefCalendarEventType = model.RefCalendarEventType; // Calendar Event Type
            StartTime = model.StartTime; // Start Time
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
