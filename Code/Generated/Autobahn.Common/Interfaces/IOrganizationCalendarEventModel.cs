//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationCalendarEventModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarEventModel Interface
     /// </summary>
    public partial interface IOrganizationCalendarEventModel : IAutobahnBase
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

    }
}
