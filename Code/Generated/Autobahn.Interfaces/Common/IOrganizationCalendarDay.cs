//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarDay.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationCalendarDay Interface
     /// </summary>
    public partial interface IOrganizationCalendarDay : IAutobahnBase
    {
        /// <summary>
        /// Alternate Day Name
        /// <para>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19591">Alternate Day Name</a>
        /// </para>
        /// </summary>
        System.String AlternateDayName { get; set; }

        System.String DayName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
        /// </summary>
        Guid OrganizationCalendarId { get; set; }

    }
}
