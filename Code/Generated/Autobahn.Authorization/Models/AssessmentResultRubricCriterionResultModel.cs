//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentResultRubricCriterionResultModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentResultRubricCriterionResult Model
     /// </summary>
    public partial class AssessmentResultRubricCriterionResultModel : AutobahnBase, Interfaces.IAssessmentResultRubricCriterionResult
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentResultId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid RubricCriterionLevelId { get; set; }

    }
}
