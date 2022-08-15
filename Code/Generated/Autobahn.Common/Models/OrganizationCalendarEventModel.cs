//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarEvent Model
     /// </summary>
    public partial class OrganizationCalendarEventModel : AutobahnBase, Interfaces.IOrganizationCalendarEvent
    {
        /// <summary>
        /// A type of scheduled or unscheduled calendar event.
        /// </summary>
        public System.Int32? RefCalendarEventType { get; set; }

    }
}
