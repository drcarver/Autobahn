//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendar Model
     /// </summary>
    public partial class OrganizationCalendarModel : AutobahnBase, Interfaces.IOrganizationCalendar
    {
        /// <summary>
        /// The year for a reported school session.
        /// </summary>
        public System.String CalendarCode { get; set; }

        /// <summary>
        /// The year for a reported school session.
        /// </summary>
        public System.String CalendarDescription { get; set; }

        /// <summary>
        /// The year for a reported school session.
        /// </summary>
        public System.String CalendarYear { get; set; }

        /// <summary>
        /// The year for a reported school session.
        /// </summary>
        public Guid OrganizationId { get; set; }

    }
}
