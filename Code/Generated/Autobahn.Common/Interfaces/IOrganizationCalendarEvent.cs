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
        System.Int32? RefCalendarEventType { get; set; }

    }
}
