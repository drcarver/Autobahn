//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationCalendarEvent.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarEvent
     /// </summary>
    public partial interface IOrganizationCalendarEvent
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        Guid OrganizationCalendarId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.EventDate non nullable property
        /// </summary>
        System.DateTime EventDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.RefCalendarEventType nullable property
        /// </summary>
        System.Int32? RefCalendarEventType { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.StartTime nullable property
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.EndTime nullable property
        /// </summary>
        System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.RecordEndDateTime nullable property
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
