//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIDEAEligibilityEvaluationCategory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIDEAEligibilityEvaluationCategory Interface
     /// </summary>
    public partial interface IIDEAEligibilityEvaluationCategory : IAutobahnBase
    {
        /// <summary>
        /// Category of evaluation used for IDEA eligibility.
        /// </summary>
        Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Category of evaluation used for IDEA eligibility.
        /// </summary>
        Guid RefIDEAEligibilityEvaluationCategoryId { get; set; }

    }
}
