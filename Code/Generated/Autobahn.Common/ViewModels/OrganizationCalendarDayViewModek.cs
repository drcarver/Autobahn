//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarDayViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarDayViewModel
     /// </summary>
    public partial class OrganizationCalendarDayViewModel : BindableBase, IOrganizationCalendarDay
    {
#region "Backing Fields"
        // member variable for the DayName property
        private System.String _DayName;

        // member variable for the AlternateDayName property
        private System.String _AlternateDayName;

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

        public System.String DayName  { get => _DayName; set => SetProperty(ref _DayName, value); }

        public System.String AlternateDayName  { get => _AlternateDayName; set => SetProperty(ref _AlternateDayName, value); }

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
        public void Load(IOrganizationCalendarDay model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationCalendarId = model.OrganizationCalendarId;
            DayName = model.DayName;
            AlternateDayName = model.AlternateDayName;
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
