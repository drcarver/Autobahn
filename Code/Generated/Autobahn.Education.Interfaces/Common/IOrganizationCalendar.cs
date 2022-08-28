//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendar.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationCalendar Interface
     /// </summary>
    public partial interface IOrganizationCalendar : IAutobahnBase
    {
        #region IOrganizationCalendar
        /// <summary>
        /// Calendar Code
        /// <para>
        /// A unique number assigned by a school district to a school calendar.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
        /// </para>
        /// </summary>
        System.String CalendarCode { get; set; }

        /// <summary>
        /// Calendar Description
        /// <para>
        /// A description or identification of the calendar.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19486">Calendar Description</a>
        /// </para>
        /// </summary>
        System.String CalendarDescription { get; set; }

        /// <summary>
        /// School Year
        /// <para>
        /// The year for a reported school session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19243">School Year</a>
        /// </para>
        /// </summary>
        System.String CalendarYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        #endregion
    }
}
