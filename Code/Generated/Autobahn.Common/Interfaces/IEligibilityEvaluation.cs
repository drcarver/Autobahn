//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEligibilityEvaluation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IEligibilityEvaluation
     /// </summary>
    public partial interface IEligibilityEvaluation
    {
        /// <summary>
        /// Defines the EligibilityEvaluation.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the EligibilityEvaluation.EvaluationDate nullable property
        /// </summary>
        System.DateTime? EvaluationDate { get; set; }

        /// <summary>
        /// Defines the EligibilityEvaluation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the EligibilityEvaluation.RecordEndDateTime nullable property
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
