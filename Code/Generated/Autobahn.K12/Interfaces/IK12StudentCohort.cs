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
        /// 
        /// </summary>
         CohortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CohortGraduationYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? CohortYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GraduationRateSurveyCohortYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
