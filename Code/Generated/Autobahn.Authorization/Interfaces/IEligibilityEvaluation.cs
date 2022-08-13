//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IEligibilityEvaluation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IEligibilityEvaluation Interface
     /// </summary>
    public partial interface IEligibilityEvaluation : IAutobahnBase
    {
        /// <summary>
        /// Description of evaluation procedure and result used for determining eligibility.
        /// </summary>
        System.DateTime? EvaluationDate { get; set; }

    }
}
