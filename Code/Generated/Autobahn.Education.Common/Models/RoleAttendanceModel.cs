//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The RoleAttendance Model
     /// </summary>
    public partial class RoleAttendanceModel : IRoleAttendance
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IRoleAttendance
        /// <summary>
        /// Student Attendance Rate
        /// <para>
        /// The number of school days during the regular school year (plus summer, if applicable, if part of implementing the restart, transformation, or turnaround model) the student attended school divided by the maximum number of days the student could have attended school during the regular school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19271">Student Attendance Rate</a>
        /// </para>
        /// </summary>
        public Decimal? AttendanceRate { get; set; }

        /// <summary>
        /// Number of Days Absent
        /// <para>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19201">Number of Days Absent</a>
        /// </para>
        /// </summary>
        public Decimal? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// Number of Days in Attendance
        /// <para>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19202">Number of Days in Attendance</a>
        /// </para>
        /// </summary>
        public Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// Number of Days Tardy
        /// <para>
        /// The number of days a person is tardy when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20948">Number of Days Tardy</a>
        /// </para>
        /// </summary>
        public Decimal? NumberOfDaysTardy { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        #endregion
    }
}
