//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarEvent Model
     /// </summary>
    public partial class OrganizationCalendarEventModel : AutobahnBase, IOrganizationCalendarEvent
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
        public TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Calendar Event Date
        /// <para>
        /// The date of the scheduled or unscheduled calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20241">Calendar Event Date</a>
        /// </para>
        /// </summary>
        public System.DateTime EventDate { get; set; }

        /// <summary>
        /// Calendar Event Day Name
        /// <para>
        /// A name used for the day of the calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20242">Calendar Event Day Name</a>
        /// </para>
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get; set; }

        /// <summary>
        /// Calendar Event Type
        /// <para>
        /// A type of scheduled or unscheduled calendar event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19596">Calendar Event Type</a>
        /// </para>
        /// </summary>
        public Int32? RefCalendarEventType { get; set; }

        /// <summary>
        /// Start Time
        /// <para>
        /// The starting hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
        /// </para>
        /// </summary>
        public TimeSpan? StartTime { get; set; }

    }
}
