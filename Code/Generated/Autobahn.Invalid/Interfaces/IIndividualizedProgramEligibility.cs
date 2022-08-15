//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramEligibility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibility Interface
     /// </summary>
    public partial interface IIndividualizedProgramEligibility : IAutobahnBase
    {
        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        System.Boolean? ConsentToEvaluateIndicator { get; set; }

    }
}
