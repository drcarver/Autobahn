//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultRubricCriterionResultModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentResultRubricCriterionResult Model
     /// </summary>
    public partial class AssessmentResultRubricCriterionResultModel : AutobahnBase, IAssessmentResultRubricCriterionResult
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        public Guid AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
        /// </summary>
        public Guid RubricCriterionLevelId { get; set; }

    }
}
