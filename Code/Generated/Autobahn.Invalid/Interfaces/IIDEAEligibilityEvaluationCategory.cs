//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIDEAEligibilityEvaluationCategory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIDEAEligibilityEvaluationCategory Interface
     /// </summary>
    public partial interface IIDEAEligibilityEvaluationCategory : IAutobahnBase
    {
        /// <summary>
        /// Category of evaluation used for IDEA eligibility.
        /// </summary>
        Guid RefIDEAEligibilityEvaluationCategoryId { get; set; }

    }
}
