//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarDay.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarDay
     /// </summary>
    public partial class OrganizationCalendarDay : IOrganizationCalendarDay
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
        /// Defines the OrganizationCalendarDay.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarDay.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
