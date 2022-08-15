//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the CalendarYear property
        private System.String _CalendarYear;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year for a reported school session.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19243">School Year</a>
        /// </para>
        /// </summary>
        [DisplayName("School Year")]
        public System.String CalendarYear { get => _CalendarYear; set => SetProperty(ref _CalendarYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendar model)
        {
            IsBusy = true;
            Id = model.Id;
            CalendarYear = model.CalendarYear; // School Year
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
