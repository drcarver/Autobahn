//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemRubricCriterionResult.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemRubricCriterionResult
     /// </summary>
    public partial class AssessmentItemRubricCriterionResult : AutobahnBase, Interfaces.IAssessmentItemRubricCriterionResult
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemResponse"/> model
        /// </summary>
        public Guid AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionLevel"/> model
        /// </summary>
        public Guid RubricCriterionLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
