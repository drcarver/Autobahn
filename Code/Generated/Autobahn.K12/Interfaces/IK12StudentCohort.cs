//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentCohort.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentCohort
     /// </summary>
    public partial interface IK12StudentCohort : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortYear non nullable property
        /// </summary>
        System.String CohortYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortGraduationYear non nullable property
        /// </summary>
        System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.GraduationRateSurveyCohortYear non nullable property
        /// </summary>
        System.String GraduationRateSurveyCohortYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.GraduationRateSurveyIndicator nullable property
        /// </summary>
        System.Boolean? GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortDescription non nullable property
        /// </summary>
        System.String CohortDescription { get; set; }

    }
}
