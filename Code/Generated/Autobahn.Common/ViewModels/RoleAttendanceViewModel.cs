//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceViewModel.cs
//* Name:       Student Attendance Rate
//* Definition: The number of school days during the regular school year (plus summer, if applicable, if part of implementing the restart, transformation, or turnaround model) the student attended school divided by the maximum number of days the student could have attended school during the regular school year.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The number of school days during the regular school year (plus summer, if applicable, if part of implementing the restart, transformation, or turnaround model) the student attended school divided by the maximum number of days the student could have attended school during the regular school year.
     /// </summary>
    public partial class RoleAttendanceViewModel : ViewModelBase, Interfaces.IRoleAttendance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendance";

        // AttendanceRate -- (backing property for Student Attendance Rate)
        private System.Decimal? _AttendanceRate;

        // NumberOfDaysAbsent -- (backing property for Number of Days Absent)
        private System.Decimal? _NumberOfDaysAbsent;

        // NumberOfDaysInAttendance -- (backing property for Number of Days in Attendance)
        private System.Decimal? _NumberOfDaysInAttendance;

        // NumberOfDaysTardy -- (backing property for Number of Days Tardy)
        private System.Decimal? _NumberOfDaysTardy;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Student Attendance Rate
        /// <para>
        /// The number of school days during the regular school year (plus summer, if applicable, if part of implementing the restart, transformation, or turnaround model) the student attended school divided by the maximum number of days the student could have attended school during the regular school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19271">Student Attendance Rate</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? AttendanceRate { get => _AttendanceRate; set => SetProperty(ref _AttendanceRate, value); }

        /// <summary>
        /// Number of Days Absent
        /// <para>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19201">Number of Days Absent</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NumberOfDaysAbsent { get => _NumberOfDaysAbsent; set => SetProperty(ref _NumberOfDaysAbsent, value); }

        /// <summary>
        /// Number of Days in Attendance
        /// <para>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19202">Number of Days in Attendance</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NumberOfDaysInAttendance { get => _NumberOfDaysInAttendance; set => SetProperty(ref _NumberOfDaysInAttendance, value); }

        /// <summary>
        /// Number of Days Tardy
        /// <para>
        /// The number of days a person is tardy when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20948">Number of Days Tardy</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NumberOfDaysTardy { get => _NumberOfDaysTardy; set => SetProperty(ref _NumberOfDaysTardy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
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
            AttendanceRate = model.AttendanceRate; // Student Attendance Rate
            NumberOfDaysAbsent = model.NumberOfDaysAbsent; // Number of Days Absent
            NumberOfDaysInAttendance = model.NumberOfDaysInAttendance; // Number of Days in Attendance
            NumberOfDaysTardy = model.NumberOfDaysTardy; // Number of Days Tardy
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
