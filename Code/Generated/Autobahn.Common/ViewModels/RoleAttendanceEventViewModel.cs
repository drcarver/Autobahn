//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceEventViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceEventViewModel
     /// </summary>
    public partial class RoleAttendanceEventViewModel : ViewModelBase, Interfaces.IRoleAttendanceEvent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendanceEvent";

        // member variable for the Date property
        private System.DateTime _Date;

        // member variable for the EndTime property
        private System.TimeSpan? _EndTime;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefAbsentAttendanceCategoryId property
        private Guid? _RefAbsentAttendanceCategoryId;

        // member variable for the RefAttendanceEventTypeId property
        private Guid? _RefAttendanceEventTypeId;

        // member variable for the RefAttendanceStatusId property
        private Guid? _RefAttendanceStatusId;

        // member variable for the RefLeaveEventTypeId property
        private Guid? _RefLeaveEventTypeId;

        // member variable for the RefPresentAttendanceCategoryId property
        private Guid? _RefPresentAttendanceCategoryId;

        // member variable for the StartTime property
        private System.TimeSpan? _StartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RoleAttendanceEventViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public System.DateTime Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public System.TimeSpan? EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAbsentAttendanceCategory"/> model
        /// </summary>
        public Guid? RefAbsentAttendanceCategoryId { get => _RefAbsentAttendanceCategoryId; set => SetProperty(ref _RefAbsentAttendanceCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceEventType"/> model
        /// </summary>
        public Guid? RefAttendanceEventTypeId { get => _RefAttendanceEventTypeId; set => SetProperty(ref _RefAttendanceEventTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAttendanceStatus"/> model
        /// </summary>
        public Guid? RefAttendanceStatusId { get => _RefAttendanceStatusId; set => SetProperty(ref _RefAttendanceStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaveEventType"/> model
        /// </summary>
        public Guid? RefLeaveEventTypeId { get => _RefLeaveEventTypeId; set => SetProperty(ref _RefLeaveEventTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPresentAttendanceCategory"/> model
        /// </summary>
        public Guid? RefPresentAttendanceCategoryId { get => _RefPresentAttendanceCategoryId; set => SetProperty(ref _RefPresentAttendanceCategoryId, value); }

        /// <summary>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </summary>
        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleAttendanceEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            Date = model.Date;
            EndTime = model.EndTime;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefAbsentAttendanceCategoryId = model.RefAbsentAttendanceCategoryId;
            RefAttendanceEventTypeId = model.RefAttendanceEventTypeId;
            RefAttendanceStatusId = model.RefAttendanceStatusId;
            RefLeaveEventTypeId = model.RefLeaveEventTypeId;
            RefPresentAttendanceCategoryId = model.RefPresentAttendanceCategoryId;
            StartTime = model.StartTime;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
