//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentCohort.cs
//* Name:       Cohort Graduation Year
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IPsStudentCohort : IAutobahnBase
    {
        /// <summary>
        /// Cohort Graduation Year
        /// <para>
        /// The year the cohort is expected to graduate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19577">Cohort Graduation Year</a>
        /// </para>
        /// </summary>
        System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
