//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12studentCohort.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12studentCohort Interface
     /// </summary>
    public partial interface IK12studentCohort : IAutobahnBase
    {
        #region IK12studentCohort
        System.String CohortDescription { get; set; }

        System.String CohortGraduationYear { get; set; }

        System.String CohortYear { get; set; }

        System.String GraduationRateSurveyCohortYear { get; set; }

        Boolean? GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        #endregion
    }
}
