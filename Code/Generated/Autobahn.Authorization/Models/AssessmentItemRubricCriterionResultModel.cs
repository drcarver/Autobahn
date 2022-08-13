//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemRubricCriterionResultModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentItemRubricCriterionResult Model
     /// </summary>
    public partial class AssessmentItemRubricCriterionResultModel : AutobahnBase, Interfaces.IAssessmentItemRubricCriterionResult
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentItemResponseId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RubricCriterionLevelId { get; set; }

    }
}
