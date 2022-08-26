//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemRubricCriterionResultModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemRubricCriterionResult Model
     /// </summary>
    public partial class AssessmentItemRubricCriterionResultModel : AutobahnBase, IAssessmentItemRubricCriterionResult
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
        /// </summary>
        public Guid AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
        /// </summary>
        public Guid RubricCriterionLevelId { get; set; }

    }
}
