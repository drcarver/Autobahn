//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarDayViewModel.cs
//**********************************************************


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

        // member variable for the OrganizationCalendarId property
        private Guid _OrganizationCalendarId;

        // member variable for the DayName property
        private System.String _DayName;

        // member variable for the AlternateDayName property
        private System.String _AlternateDayName;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarDayViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarId"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get => _OrganizationCalendarId; set => SetProperty(ref _OrganizationCalendarId, value); }

        public System.String DayName  { get => _DayName; set => SetProperty(ref _DayName, value); }

        public System.String AlternateDayName  { get => _AlternateDayName; set => SetProperty(ref _AlternateDayName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarDay model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationCalendarId = model.OrganizationCalendarId;
            DayName = model.DayName;
            AlternateDayName = model.AlternateDayName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
