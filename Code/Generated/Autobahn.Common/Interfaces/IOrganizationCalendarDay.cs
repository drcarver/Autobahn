//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarDay.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarDay Interface
     /// </summary>
    public partial interface IOrganizationCalendarDay : IAutobahnBase
    {
        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </summary>
        System.String AlternateDayName { get; set; }

        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </summary>
        System.String DayName { get; set; }

        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </summary>
        Guid OrganizationCalendarId { get; set; }

    }
}
