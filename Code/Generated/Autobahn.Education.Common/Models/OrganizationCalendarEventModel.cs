//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarEvent Model
     /// </summary>
    public partial class OrganizationCalendarEventModel : IOrganizationCalendarEvent
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

        #region IOrganizationCalendarEvent
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

        #endregion
    }
}
