//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentCohort.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentCohort Interface
     /// </summary>
    public partial interface IK12StudentCohort : IAutobahnBase
    {
        /// <summary>
        /// The school year in which the student entered the baseline group used for computing completion rates (e.g., high school, program).
        /// </summary>
        System.String CohortYear { get; set; }

    }
}
