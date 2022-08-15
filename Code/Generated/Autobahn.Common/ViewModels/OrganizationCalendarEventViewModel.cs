//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RefCalendarEventType property
        private System.Int32? _RefCalendarEventType;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarEventViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19596">Calendar Event Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Calendar Event Type")]
        public System.Int32? RefCalendarEventType { get => _RefCalendarEventType; set => SetProperty(ref _RefCalendarEventType, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCalendarEventType = model.RefCalendarEventType; // Calendar Event Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
