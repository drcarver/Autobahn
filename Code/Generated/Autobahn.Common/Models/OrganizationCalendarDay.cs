//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarDay.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarDay
     /// </summary>
    public partial class OrganizationCalendarDay : AutobahnBase, Interfaces.IOrganizationCalendarDay
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarDay.DayName non nullable property
        /// </summary>
        public System.String DayName { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarDay.AlternateDayName non nullable property
        /// </summary>
        public System.String AlternateDayName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
