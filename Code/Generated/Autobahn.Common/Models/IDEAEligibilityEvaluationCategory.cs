//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IDEAEligibilityEvaluationCategory.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategory
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategory : IIDEAEligibilityEvaluationCategory
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="EligibilityEvaluation"/> model
        /// </summary>
        public Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIDEAEligibilityEvaluationCategory"/> model
        /// </summary>
        public Guid RefIDEAEligibilityEvaluationCategoryId { get; set; }

        /// <summary>
        /// Defines the IDEAEligibilityEvaluationCategory.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IDEAEligibilityEvaluationCategory.RecordEndDateTime nullable property
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
