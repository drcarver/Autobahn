//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceViewModel
     /// </summary>
    public partial class RoleAttendanceViewModel : ViewModelBase, Interfaces.IRoleAttendance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendance";

        // member variable for the AttendanceRate property
        private System.Decimal? _AttendanceRate;

        // member variable for the NumberOfDaysAbsent property
        private System.Decimal? _NumberOfDaysAbsent;

        // member variable for the NumberOfDaysInAttendance property
        private System.Decimal? _NumberOfDaysInAttendance;

        // member variable for the NumberOfDaysTardy property
        private System.Decimal? _NumberOfDaysTardy;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RoleAttendanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? AttendanceRate { get => _AttendanceRate; set => SetProperty(ref _AttendanceRate, value); }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? NumberOfDaysAbsent { get => _NumberOfDaysAbsent; set => SetProperty(ref _NumberOfDaysAbsent, value); }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? NumberOfDaysInAttendance { get => _NumberOfDaysInAttendance; set => SetProperty(ref _NumberOfDaysInAttendance, value); }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? NumberOfDaysTardy { get => _NumberOfDaysTardy; set => SetProperty(ref _NumberOfDaysTardy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            AttendanceRate = model.AttendanceRate;
            NumberOfDaysAbsent = model.NumberOfDaysAbsent;
            NumberOfDaysInAttendance = model.NumberOfDaysInAttendance;
            NumberOfDaysTardy = model.NumberOfDaysTardy;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
