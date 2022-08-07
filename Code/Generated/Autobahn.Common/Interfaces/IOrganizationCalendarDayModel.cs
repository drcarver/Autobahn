//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationCalendarDayModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarDayModel Interface
     /// </summary>
    public partial interface IOrganizationCalendarDayModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        Guid OrganizationCalendarId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarDay.DayName non nullable property
        /// </summary>
        System.String DayName { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarDay.AlternateDayName non nullable property
        /// </summary>
        System.String AlternateDayName { get; set; }

    }
}
