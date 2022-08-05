//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentResultRubricCriterionResult.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentResultRubricCriterionResult
     /// </summary>
    public partial class AssessmentResultRubricCriterionResult : AutobahnBase, Interfaces.IAssessmentResultRubricCriterionResult
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        public Guid AssessmentResultId { get; set; }

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
