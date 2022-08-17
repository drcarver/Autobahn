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
        /// End Time
        /// <para>
        /// The ending hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
        /// </para>
        /// </summary>
        System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Calendar Event Date
        /// <para>
        /// The date of the scheduled or unscheduled calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20241">Calendar Event Date</a>
        /// </para>
        /// </summary>
        System.DateTime EventDate { get; set; }

        /// <summary>
        /// Calendar Event Day Name
        /// <para>
        /// A name used for the day of the calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20242">Calendar Event Day Name</a>
        /// </para>
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Calendar Code
        /// <para>
        /// A unique number assigned by a school district to a school calendar.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
        /// </para>
        /// </summary>
        Guid OrganizationCalendarId { get; set; }

        /// <summary>
        /// Calendar Event Type
        /// <para>
        /// A type of scheduled or unscheduled calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19596">Calendar Event Type</a>
        /// </para>
        /// </summary>
        System.Int32? RefCalendarEventType { get; set; }

        /// <summary>
        /// Start Time
        /// <para>
        /// The starting hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
        /// </para>
        /// </summary>
        System.TimeSpan? StartTime { get; set; }

    }
}
