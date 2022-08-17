//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IIDEAEligibilityEvaluationCategory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IIDEAEligibilityEvaluationCategory Interface
     /// </summary>
    public partial interface IIDEAEligibilityEvaluationCategory : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
        /// </summary>
        Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIDEAEligibilityEvaluationCategory"/> model
        /// </summary>
        Guid RefIDEAEligibilityEvaluationCategoryId { get; set; }

    }
}
