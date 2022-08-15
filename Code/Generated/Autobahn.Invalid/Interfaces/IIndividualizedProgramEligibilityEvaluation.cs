//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramEligibilityEvaluation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibilityEvaluation Interface
     /// </summary>
    public partial interface IIndividualizedProgramEligibilityEvaluation : IAutobahnBase
    {
        /// <summary>
        /// Purpose within the IEP lifecycle for which the eligibility evaluation is conducted.
        /// </summary>
        Guid? RefIEPEligibilityEvaluationTypeId { get; set; }

    }
}
