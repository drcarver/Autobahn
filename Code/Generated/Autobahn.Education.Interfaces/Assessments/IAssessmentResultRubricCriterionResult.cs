//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentResultRubricCriterionResult.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentResultRubricCriterionResult Interface
     /// </summary>
    public partial interface IAssessmentResultRubricCriterionResult : IAutobahnBase
    {
        #region IAssessmentResultRubricCriterionResult
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
        /// </summary>
        Guid RubricCriterionLevelId { get; set; }

        #endregion
    }
}
