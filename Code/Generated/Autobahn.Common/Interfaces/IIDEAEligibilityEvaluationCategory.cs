//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIDEAEligibilityEvaluationCategory.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIDEAEligibilityEvaluationCategory
     /// </summary>
    public partial interface IIDEAEligibilityEvaluationCategory : IAutobahnBase
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
