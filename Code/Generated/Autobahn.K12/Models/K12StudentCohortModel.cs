//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCohortModel.cs
//* Name:       Cohort Description
//* Definition: A description of the student cohort.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// A description of the student cohort.
     /// </summary>
    public partial class K12StudentCohortModel : AutobahnBase, Interfaces.IK12StudentCohort
    {
        /// <summary>
        /// Cohort Description
        /// <para>
        /// A description of the student cohort.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19687">Cohort Description</a>
        /// </para>
        /// </summary>
        public System.String CohortDescription { get; set; }

        /// <summary>
        /// Cohort Graduation Year
        /// <para>
        /// The year the cohort is expected to graduate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19577">Cohort Graduation Year</a>
        /// </para>
        /// </summary>
        public System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// Cohort Year
        /// <para>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19046">Cohort Year</a>
        /// </para>
        /// </summary>
        public System.String CohortYear { get; set; }

        /// <summary>
        /// Graduation Rate Survey Cohort Year
        /// <para>
        /// The academic year in which a student entered as part of the GRS cohort.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19132">Graduation Rate Survey Cohort Year</a>
        /// </para>
        /// </summary>
        public System.String GraduationRateSurveyCohortYear { get; set; }

        /// <summary>
        /// Graduation Rate Survey Indicator
        /// <para>
        /// An indication of whether or not the student is in a GRS cohort; meaning the student began as a first-time, full-time, degree seeking student in the fall of a given year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19133">Graduation Rate Survey Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
