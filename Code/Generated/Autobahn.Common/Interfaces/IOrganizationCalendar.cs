//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendar.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendar Interface
     /// </summary>
    public partial interface IOrganizationCalendar : IAutobahnBase
    {
        /// <summary>
        /// The year for a reported school session.
        /// </summary>
        System.String CalendarYear { get; set; }

    }
}
