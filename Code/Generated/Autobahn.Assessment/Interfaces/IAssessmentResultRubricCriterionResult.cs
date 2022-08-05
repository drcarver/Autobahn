//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentResultRubricCriterionResult.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentResultRubricCriterionResult
     /// </summary>
    public partial interface IAssessmentResultRubricCriterionResult : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionLevel"/> model
        /// </summary>
        Guid RubricCriterionLevelId { get; set; }

    }
}
