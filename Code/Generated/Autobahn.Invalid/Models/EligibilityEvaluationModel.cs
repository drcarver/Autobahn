//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   EligibilityEvaluationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The EligibilityEvaluation Model
     /// </summary>
    public partial class EligibilityEvaluationModel : AutobahnBase, Interfaces.IEligibilityEvaluation
    {
        /// <summary>
        /// Description of evaluation procedure and result used for determining eligibility.
        /// </summary>
        public System.DateTime? EvaluationDate { get; set; }

    }
}
