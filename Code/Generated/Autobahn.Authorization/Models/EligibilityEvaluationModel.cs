//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   EligibilityEvaluationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
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
