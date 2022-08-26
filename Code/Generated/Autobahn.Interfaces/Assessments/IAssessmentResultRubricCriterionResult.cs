//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentResultRubricCriterionResult.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentResultRubricCriterionResult Interface
     /// </summary>
    public partial interface IAssessmentResultRubricCriterionResult : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
        /// </summary>
        Guid RubricCriterionLevelId { get; set; }

    }
}
