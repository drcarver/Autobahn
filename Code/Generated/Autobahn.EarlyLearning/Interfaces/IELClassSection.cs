//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELClassSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELClassSection Interface
     /// </summary>
    public partial interface IELClassSection : IAutobahnBase
    {
        /// <summary>
        /// Days Available Per Week
        /// <para>
        /// The number of days per week the site or classroom is open for children to attend.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19354">Days Available Per Week</a>
        /// </para>
        /// </summary>
        System.Int32? DaysAvailablePerWeek { get; set; }

        /// <summary>
        /// Early Learning Program Annual Operating Weeks
        /// <para>
        /// The number of operating weeks per year for an early learning program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19824">Early Learning Program Annual Operating Weeks</a>
        /// </para>
        /// </summary>
        System.Int32? ELProgramAnnualOperatingWeeks { get; set; }

        /// <summary>
        /// Early Learning Group Size
        /// <para>
        /// The number of slots/spaces available.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20295">Early Learning Group Size</a>
        /// </para>
        /// </summary>
        System.Int32? GroupSize { get; set; }

        /// <summary>
        /// Hours Available Per Day
        /// <para>
        /// The number of hours per day the site or classroom is open for children to attend.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19353">Hours Available Per Day</a>
        /// </para>
        /// </summary>
        System.Decimal? HoursAvailablePerDay { get; set; }

        /// <summary>
        /// Language Translation Policy
        /// <para>
        /// Indicates that the organization or class/group has  translation services available .
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20190">Language Translation Policy</a>
        /// </para>
        /// </summary>
        System.Boolean? LanguageTranslationPolicy { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
        /// </summary>
        Guid? RefEnvironmentSettingId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        Guid? RefServiceOptionId { get; set; }

    }
}
