//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemRubricCriterionResult.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemRubricCriterionResult
     /// </summary>
    public partial interface IAssessmentItemRubricCriterionResult : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemResponse"/> model
        /// </summary>
        Guid AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionLevel"/> model
        /// </summary>
        Guid RubricCriterionLevelId { get; set; }

    }
}
