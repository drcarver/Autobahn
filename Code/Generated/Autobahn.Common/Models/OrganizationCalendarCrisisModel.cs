//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisisModel.cs
//* Name:       Crisis Code
//* Definition: A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
     /// </summary>
    public partial class OrganizationCalendarCrisisModel : AutobahnBase, Interfaces.IOrganizationCalendarCrisis
    {
        /// <summary>
        /// Crisis Description
        /// <para>
        /// A description of the crisis that caused the displacement of students.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20526">Crisis Description</a>
        /// </para>
        /// </summary>
        public System.String CrisisDescription { get; set; }

        /// <summary>
        /// Crisis End Date
        /// <para>
        /// The date on which the crisis ceased to affect the agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20528">Crisis End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CrisisEndDate { get; set; }

        /// <summary>
        /// Crisis End Date
        /// <para>
        /// The date on which the crisis ceased to affect the agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20528">Crisis End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Crisis Name
        /// <para>
        /// The name of the crisis that caused the displacement of students.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19605">Crisis Name</a>
        /// </para>
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Crisis Start Date
        /// <para>
        /// The year, month and day on which the crisis affected the agency. This date may not be the same as the date the crisis occurred if evacuation orders are implemented in anticipation of a crisis.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19607">Crisis Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Crisis Type
        /// <para>
        /// The type or category of crisis (ex., chemical, earthquake, flood, wildfire, etc.).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19606">Crisis Type</a>
        /// </para>
        /// </summary>
        public System.String Type { get; set; }

    }
}
