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

        // member variable for the EndTime property
        private  _EndTime;

        // member variable for the EventDate property
        private  _EventDate;

        // member variable for the Name property
        private  _Name;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCalendarEventType property
        private Guid? _RefCalendarEventType;

        // member variable for the StartTime property
        private  _StartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// </summary>
        public  EventDate { get => _EventDate; set => SetProperty(ref _EventDate, value); }

        /// <summary>
        /// </summary>
        public  Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? RefCalendarEventType { get => _RefCalendarEventType; set => SetProperty(ref _RefCalendarEventType, value); }

        /// <summary>
        /// </summary>
        public  StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            EndTime = model.EndTime; // 
            EventDate = model.EventDate; // 
            Name = model.Name; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCalendarEventType = model.RefCalendarEventType; // 
            StartTime = model.StartTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
