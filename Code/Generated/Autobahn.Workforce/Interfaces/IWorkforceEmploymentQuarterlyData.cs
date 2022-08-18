//***************************************************************************
//* DomainName: Workforce Interfaces (used by both models and View Models
//* FileName:   IWorkforceEmploymentQuarterlyData.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceEmploymentQuarterlyData Interface
     /// </summary>
    public partial interface IWorkforceEmploymentQuarterlyData : IAutobahnBase
    {
        /// <summary>
        /// Person Employed in Multiple Jobs Count
        /// <para>
        /// The number of jobs held by a person during the reference period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19993">Person Employed in Multiple Jobs Count</a>
        /// </para>
        /// </summary>
        System.Decimal? EmployedInMultipleJobsCount { get; set; }

        /// <summary>
        /// Military Enlistment After Exit
        /// <para>
        /// An individual who is a member of the uniformed armed forces of the United States as reported through FEDES after exiting secondary, postsecondary, or adult education or workforce programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20381">Military Enlistment After Exit</a>
        /// </para>
        /// </summary>
        System.Boolean? MilitaryEnlistmentAfterExit { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

    }
}
