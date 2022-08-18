//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationAvailabilityModel.cs
//* Name:       Early Learning Program Annual Operating Weeks
//* Definition: The number of operating weeks per year for an early learning program.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The number of operating weeks per year for an early learning program.
     /// </summary>
    public partial class ELOrganizationAvailabilityModel : AutobahnBase, Interfaces.IELOrganizationAvailability
    {
        /// <summary>
        /// Early Learning Program Annual Operating Weeks
        /// <para>
        /// The number of operating weeks per year for an early learning program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19824">Early Learning Program Annual Operating Weeks</a>
        /// </para>
        /// </summary>
        public System.Int32? AnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Days Available Per Week
        /// <para>
        /// The number of days per week the site or classroom is open for children to attend.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19354">Days Available Per Week</a>
        /// </para>
        /// </summary>
        public System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Hours Available Per Day
        /// <para>
        /// The number of hours per day the site or classroom is open for children to attend.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19353">Hours Available Per Day</a>
        /// </para>
        /// </summary>
        public System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Number of Classrooms
        /// <para>
        /// The total number of classrooms for a program, facility, location, or other educational environment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19844">Number of Classrooms</a>
        /// </para>
        /// </summary>
        public System.Int32? NumberOfClassrooms { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
        /// </summary>
        public Guid? RefEnvironmentSettingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        public Guid? RefServiceOptionId { get; set; }

    }
}
