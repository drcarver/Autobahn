//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIDEAEligibilityEvaluationCategoryModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIDEAEligibilityEvaluationCategoryModel Interface
     /// </summary>
    public partial interface IIDEAEligibilityEvaluationCategoryModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="EligibilityEvaluation"/> model
        /// </summary>
        Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIDEAEligibilityEvaluationCategory"/> model
        /// </summary>
        Guid RefIDEAEligibilityEvaluationCategoryId { get; set; }

    }
}
