//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationCalendarDay.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarDay
     /// </summary>
    public partial interface IOrganizationCalendarDay
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

        /// <summary>
        /// Defines the OrganizationCalendarDay.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarDay.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
