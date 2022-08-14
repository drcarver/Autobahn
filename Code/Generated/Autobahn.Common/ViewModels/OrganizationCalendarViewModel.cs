//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarViewModel
     /// </summary>
    public partial class OrganizationCalendarViewModel : ViewModelBase, Interfaces.IOrganizationCalendar
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendar";

        // member variable for the CalendarCode property
        private System.String _CalendarCode;

        // member variable for the CalendarDescription property
        private System.String _CalendarDescription;

        // member variable for the CalendarYear property
        private System.String _CalendarYear;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year for a reported school session.
        /// </summary>
        public System.String CalendarCode { get => _CalendarCode; set => SetProperty(ref _CalendarCode, value); }

        /// <summary>
        /// The year for a reported school session.
        /// </summary>
        public System.String CalendarDescription { get => _CalendarDescription; set => SetProperty(ref _CalendarDescription, value); }

        /// <summary>
        /// The year for a reported school session.
        /// </summary>
        public System.String CalendarYear { get => _CalendarYear; set => SetProperty(ref _CalendarYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendar model)
        {
            IsBusy = true;
            Id = model.Id;
            CalendarCode = model.CalendarCode;
            CalendarDescription = model.CalendarDescription;
            CalendarYear = model.CalendarYear;
            OrganizationId = model.OrganizationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
