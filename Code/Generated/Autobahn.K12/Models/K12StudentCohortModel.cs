//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentCohortModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCohort Model
     /// </summary>
    public partial class K12StudentCohortModel : AutobahnBase, Interfaces.IK12StudentCohort
    {
        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.String CohortDescription { get; set; }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.String CohortYear { get; set; }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.String GraduationRateSurveyCohortYear { get; set; }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public System.Boolean? GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
