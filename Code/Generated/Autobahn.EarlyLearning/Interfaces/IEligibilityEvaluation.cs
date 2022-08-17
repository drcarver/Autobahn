//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IEligibilityEvaluation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IEligibilityEvaluation Interface
     /// </summary>
    public partial interface IEligibilityEvaluation : IAutobahnBase
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
        System.DateTime? EvaluationDate { get; set; }

    }
}
