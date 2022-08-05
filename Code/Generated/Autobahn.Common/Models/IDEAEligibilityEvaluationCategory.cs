//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IDEAEligibilityEvaluationCategory.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategory
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategory : AutobahnBase, Interfaces.IIDEAEligibilityEvaluationCategory
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
