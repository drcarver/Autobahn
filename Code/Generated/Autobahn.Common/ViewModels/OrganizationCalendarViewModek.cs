//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarViewModel
     /// </summary>
    public partial class OrganizationCalendarViewModel : BindableBase, IOrganizationCalendar
    {
#region "Backing Fields"
        // member variable for the CalendarCode property
        private System.String _CalendarCode;

        // member variable for the CalendarDescription property
        private System.String _CalendarDescription;

        // member variable for the CalendarYear property
        private System.String _CalendarYear;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.String CalendarCode  { get => _CalendarCode; set => SetProperty(ref _CalendarCode, value); }

        public System.String CalendarDescription  { get => _CalendarDescription; set => SetProperty(ref _CalendarDescription, value); }

        public System.String CalendarYear  { get => _CalendarYear; set => SetProperty(ref _CalendarYear, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IOrganizationCalendar model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            CalendarCode = model.CalendarCode;
            CalendarDescription = model.CalendarDescription;
            CalendarYear = model.CalendarYear;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
