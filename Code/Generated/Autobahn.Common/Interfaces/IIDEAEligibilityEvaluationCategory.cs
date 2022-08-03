//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIDEAEligibilityEvaluationCategory.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIDEAEligibilityEvaluationCategory
     /// </summary>
    public partial interface IIDEAEligibilityEvaluationCategory
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="EligibilityEvaluation"/> model
        /// </summary>
        Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIDEAEligibilityEvaluationCategory"/> model
        /// </summary>
        Guid RefIDEAEligibilityEvaluationCategoryId { get; set; }

        /// <summary>
        /// Defines the IDEAEligibilityEvaluationCategory.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IDEAEligibilityEvaluationCategory.RecordEndDateTime nullable property
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
