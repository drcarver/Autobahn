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

        // member variable for the CalendarCode property
        private  _CalendarCode;

        // member variable for the CalendarDescription property
        private  _CalendarDescription;

        // member variable for the CalendarYear property
        private Guid? _CalendarYear;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CalendarCode { get => _CalendarCode; set => SetProperty(ref _CalendarCode, value); }

        /// <summary>
        /// </summary>
        public  CalendarDescription { get => _CalendarDescription; set => SetProperty(ref _CalendarDescription, value); }

        /// <summary>
        /// </summary>
        public Guid? CalendarYear { get => _CalendarYear; set => SetProperty(ref _CalendarYear, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendar model)
        {
            IsBusy = true;
            Id = model.Id;
            CalendarCode = model.CalendarCode; // 
            CalendarDescription = model.CalendarDescription; // 
            CalendarYear = model.CalendarYear; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
