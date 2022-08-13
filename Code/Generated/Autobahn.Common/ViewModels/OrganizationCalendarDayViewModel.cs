//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarDayViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarDayViewModel
     /// </summary>
    public partial class OrganizationCalendarDayViewModel : ViewModelBase, Interfaces.IOrganizationCalendarDay
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarDay";

        // member variable for the AlternateDayName property
        private System.String _AlternateDayName;

        // member variable for the DayName property
        private System.String _DayName;

        // member variable for the OrganizationCalendarId property
        private Guid _OrganizationCalendarId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarDayViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </summary>
        public System.String AlternateDayName { get => _AlternateDayName; set => SetProperty(ref _AlternateDayName, value); }

        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </summary>
        public System.String DayName { get => _DayName; set => SetProperty(ref _DayName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get => _OrganizationCalendarId; set => SetProperty(ref _OrganizationCalendarId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarDay model)
        {
            IsBusy = true;
            Id = model.Id;
            AlternateDayName = model.AlternateDayName;
            DayName = model.DayName;
            OrganizationCalendarId = model.OrganizationCalendarId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
