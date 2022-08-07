//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemRubricCriterionResultModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemRubricCriterionResultModel Interface
     /// </summary>
    public partial interface IAssessmentItemRubricCriterionResultModel : IAutobahnBase
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
