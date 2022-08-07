//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentResult_PerformanceLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentResult_PerformanceLevelModel Interface
     /// </summary>
    public partial interface IAssessmentResult_PerformanceLevelModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPerformanceLevel"/> model
        /// </summary>
        Guid AssessmentPerformanceLevelId { get; set; }

    }
}
