//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemRubricCriterionResult.cs
//**********************************************************

using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemRubricCriterionResult
     /// </summary>
    public partial class AssessmentItemRubricCriterionResult : IAssessmentItemRubricCriterionResult
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
        /// Defines the AssessmentItemRubricCriterionResult.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemRubricCriterionResult.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
