//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationCalendar.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendar
     /// </summary>
    public partial interface IOrganizationCalendar : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendar.CalendarCode non nullable property
        /// </summary>
        System.String CalendarCode { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendar.CalendarDescription non nullable property
        /// </summary>
        System.String CalendarDescription { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendar.CalendarYear non nullable property
        /// </summary>
        System.String CalendarYear { get; set; }

    }
}
