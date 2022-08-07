//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendanceViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceViewModel
     /// </summary>
    public partial class RoleAttendanceViewModel : ViewModelBase, Interfaces.IRoleAttendanceViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendance";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the NumberOfDaysInAttendance property
        private System.Decimal? _NumberOfDaysInAttendance;

        // member variable for the NumberOfDaysAbsent property
        private System.Decimal? _NumberOfDaysAbsent;

        // member variable for the AttendanceRate property
        private System.Decimal? _AttendanceRate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the NumberOfDaysTardy property
        private System.Decimal? _NumberOfDaysTardy;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the RoleAttendanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Decimal? NumberOfDaysInAttendance { get => _NumberOfDaysInAttendance; set => SetProperty(ref _NumberOfDaysInAttendance, value); }

        public System.Decimal? NumberOfDaysAbsent { get => _NumberOfDaysAbsent; set => SetProperty(ref _NumberOfDaysAbsent, value); }

        public System.Decimal? AttendanceRate { get => _AttendanceRate; set => SetProperty(ref _AttendanceRate, value); }

        public System.Decimal? NumberOfDaysTardy { get => _NumberOfDaysTardy; set => SetProperty(ref _NumberOfDaysTardy, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            NumberOfDaysInAttendance = model.NumberOfDaysInAttendance;
            NumberOfDaysAbsent = model.NumberOfDaysAbsent;
            AttendanceRate = model.AttendanceRate;
            NumberOfDaysTardy = model.NumberOfDaysTardy;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
