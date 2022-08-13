//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRoleAttendance.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleAttendance Interface
     /// </summary>
    public partial interface IRoleAttendance : IAutobahnBase
    {
        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        System.Decimal? AttendanceRate { get; set; }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        System.Decimal? NumberOfDaysAbsent { get; set; }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        System.Decimal? NumberOfDaysTardy { get; set; }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}