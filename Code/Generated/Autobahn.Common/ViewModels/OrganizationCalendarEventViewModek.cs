//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarEventViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarEventViewModel
     /// </summary>
    public partial class OrganizationCalendarEventViewModel : BindableBase, IOrganizationCalendarEvent
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarId"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get; set; }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.DateTime EventDate  { get => _EventDate; set => SetProperty(ref _EventDate, value); }

        public System.Int32? RefCalendarEventType { get => _RefCalendarEventType; set => SetProperty(ref _RefCalendarEventType, value); }

        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        public System.TimeSpan? EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

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
        public void Load(IOrganizationCalendarEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationCalendarId = model.OrganizationCalendarId;
            Name = model.Name;
            EventDate = model.EventDate;
            RefCalendarEventType = model.RefCalendarEventType;
            StartTime = model.StartTime;
            EndTime = model.EndTime;
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
