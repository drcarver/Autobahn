//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarEventModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarEvent Model
     /// </summary>
    public partial class OrganizationCalendarEventModel : AutobahnBase, Interfaces.IOrganizationCalendarEventModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.EventDate non nullable property
        /// </summary>
        public System.DateTime EventDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.RefCalendarEventType nullable property
        /// </summary>
        public System.Int32? RefCalendarEventType { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.StartTime nullable property
        /// </summary>
        public System.TimeSpan? StartTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarEvent.EndTime nullable property
        /// </summary>
        public System.TimeSpan? EndTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
