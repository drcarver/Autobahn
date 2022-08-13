//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarEvent.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarEvent Interface
     /// </summary>
    public partial interface IOrganizationCalendarEvent : IAutobahnBase
    {
        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        System.DateTime EventDate { get; set; }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        Guid OrganizationCalendarId { get; set; }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        System.Int32? RefCalendarEventType { get; set; }

        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

    }
}
