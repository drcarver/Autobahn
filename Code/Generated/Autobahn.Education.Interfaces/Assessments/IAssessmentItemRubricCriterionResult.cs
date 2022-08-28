//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemRubricCriterionResult.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentItemRubricCriterionResult Interface
     /// </summary>
    public partial interface IAssessmentItemRubricCriterionResult : IAutobahnBase
    {
        #region IAssessmentItemRubricCriterionResult
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
        /// </summary>
        Guid AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
        /// </summary>
        Guid RubricCriterionLevelId { get; set; }

        #endregion
    }
}
