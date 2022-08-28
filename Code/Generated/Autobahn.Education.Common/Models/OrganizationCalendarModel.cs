//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The OrganizationCalendar Model
     /// </summary>
    public partial class OrganizationCalendarModel : IOrganizationCalendar
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

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
        public System.String CalendarCode { get; set; }

        /// <summary>
        /// Calendar Description
        /// <para>
        /// A description or identification of the calendar.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19486">Calendar Description</a>
        /// </para>
        /// </summary>
        public System.String CalendarDescription { get; set; }

        /// <summary>
        /// School Year
        /// <para>
        /// The year for a reported school session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19243">School Year</a>
        /// </para>
        /// </summary>
        public System.String CalendarYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        #endregion
    }
}
