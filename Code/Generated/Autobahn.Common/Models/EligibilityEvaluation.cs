//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   EligibilityEvaluation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The EligibilityEvaluation
     /// </summary>
    public partial class EligibilityEvaluation : IEligibilityEvaluation
    {
        /// <summary>
        /// Defines the EligibilityEvaluation.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the EligibilityEvaluation.EvaluationDate nullable property
        /// </summary>
        public System.DateTime? EvaluationDate { get; set; }

        /// <summary>
        /// Defines the EligibilityEvaluation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the EligibilityEvaluation.RecordEndDateTime nullable property
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
