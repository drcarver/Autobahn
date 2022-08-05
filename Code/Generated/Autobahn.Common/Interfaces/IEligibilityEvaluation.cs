//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEligibilityEvaluation.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IEligibilityEvaluation
     /// </summary>
    public partial interface IEligibilityEvaluation : IAutobahnBase
    {
        /// <summary>
        /// Defines the EligibilityEvaluation.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the EligibilityEvaluation.EvaluationDate nullable property
        /// </summary>
        System.DateTime? EvaluationDate { get; set; }

    }
}
