//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentResultRubricCriterionResultModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentResultRubricCriterionResultModel Interface
     /// </summary>
    public partial interface IAssessmentResultRubricCriterionResultModel : IAutobahnBase
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
