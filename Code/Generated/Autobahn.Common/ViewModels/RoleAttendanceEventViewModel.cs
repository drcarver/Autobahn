//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleAttendanceEventViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceEventViewModel
     /// </summary>
    public partial class RoleAttendanceEventViewModel : ViewModelBase, Interfaces.IRoleAttendanceEventViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendanceEvent";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the Date property
        private System.DateTime _Date;

        // member variable for the RefAttendanceEventTypeId property
        private Guid? _RefAttendanceEventTypeId;

        // member variable for the RefAttendanceStatusId property
        private Guid? _RefAttendanceStatusId;

        // member variable for the RefAbsentAttendanceCategoryId property
        private Guid? _RefAbsentAttendanceCategoryId;

        // member variable for the RefPresentAttendanceCategoryId property
        private Guid? _RefPresentAttendanceCategoryId;

        // member variable for the RefLeaveEventTypeId property
        private Guid? _RefLeaveEventTypeId;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        // member variable for the EndTime property
        private System.TimeSpan? _EndTime;

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
        /// The title of the RoleAttendanceEventViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.DateTime Date  { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceEventTypeId"/> model
        /// </summary>
        public Guid? RefAttendanceEventTypeId { get => _RefAttendanceEventTypeId; set => SetProperty(ref _RefAttendanceEventTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceStatusId"/> model
        /// </summary>
        public Guid? RefAttendanceStatusId { get => _RefAttendanceStatusId; set => SetProperty(ref _RefAttendanceStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAbsentAttendanceCategoryId"/> model
        /// </summary>
        public Guid? RefAbsentAttendanceCategoryId { get => _RefAbsentAttendanceCategoryId; set => SetProperty(ref _RefAbsentAttendanceCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPresentAttendanceCategoryId"/> model
        /// </summary>
        public Guid? RefPresentAttendanceCategoryId { get => _RefPresentAttendanceCategoryId; set => SetProperty(ref _RefPresentAttendanceCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaveEventTypeId"/> model
        /// </summary>
        public Guid? RefLeaveEventTypeId { get => _RefLeaveEventTypeId; set => SetProperty(ref _RefLeaveEventTypeId, value); }

        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        public System.TimeSpan? EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleAttendanceEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            Date = model.Date;
            RefAttendanceEventTypeId = model.RefAttendanceEventTypeId;
            RefAttendanceStatusId = model.RefAttendanceStatusId;
            RefAbsentAttendanceCategoryId = model.RefAbsentAttendanceCategoryId;
            RefPresentAttendanceCategoryId = model.RefPresentAttendanceCategoryId;
            RefLeaveEventTypeId = model.RefLeaveEventTypeId;
            StartTime = model.StartTime;
            EndTime = model.EndTime;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
