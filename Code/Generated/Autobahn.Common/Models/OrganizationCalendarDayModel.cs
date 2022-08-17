//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarDayModel.cs
//* Name:       Alternate Day Name
//* Definition: An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
     /// </summary>
    public partial class OrganizationCalendarDayModel : AutobahnBase, Interfaces.IOrganizationCalendarDay
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
        public System.String AlternateDayName { get; set; }

        public System.String DayName { get; set; }

        /// <summary>
        /// Calendar Code
        /// <para>
        /// A unique number assigned by a school district to a school calendar.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
        /// </para>
        /// </summary>
        public Guid OrganizationCalendarId { get; set; }

    }
}
