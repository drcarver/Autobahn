//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemRubricCriterionResult.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentItemRubricCriterionResult Interface
     /// </summary>
    public partial interface IAssessmentItemRubricCriterionResult : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
        /// </summary>
        Guid AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
        /// </summary>
        Guid RubricCriterionLevelId { get; set; }

    }
}
