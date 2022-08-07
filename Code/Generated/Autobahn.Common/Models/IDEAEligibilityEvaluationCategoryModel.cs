//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IDEAEligibilityEvaluationCategoryModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategory Model
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategoryModel : AutobahnBase, Interfaces.IIDEAEligibilityEvaluationCategoryModel
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
