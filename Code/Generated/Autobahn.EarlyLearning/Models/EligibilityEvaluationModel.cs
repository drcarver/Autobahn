//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EligibilityEvaluationModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The EligibilityEvaluation Model
     /// </summary>
    public partial class EligibilityEvaluationModel : AutobahnBase, Interfaces.IEligibilityEvaluation
    {
        /// <summary>
        /// Eligibility Evaluation Date
        /// <para>
        /// The date when the evaluation to determine eligibility was conducted.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20712">Eligibility Evaluation Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? EvaluationDate { get; set; }

    }
}
