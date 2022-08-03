//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentItemRubricCriterionResult.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentItemRubricCriterionResult
     /// </summary>
    public partial interface IAssessmentItemRubricCriterionResult
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemResponse"/> model
        /// </summary>
        Guid AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionLevel"/> model
        /// </summary>
        Guid RubricCriterionLevelId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemRubricCriterionResult.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentItemRubricCriterionResult.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
