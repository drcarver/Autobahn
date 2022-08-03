//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendar.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendar
     /// </summary>
    public partial class OrganizationCalendar : IOrganizationCalendar
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendar.CalendarCode non nullable property
        /// </summary>
        public System.String CalendarCode { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendar.CalendarDescription non nullable property
        /// </summary>
        public System.String CalendarDescription { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendar.CalendarYear non nullable property
        /// </summary>
        public System.String CalendarYear { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendar.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendar.RecordEndDateTime nullable property
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