//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEligibilityEvaluationModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IEligibilityEvaluationModel Interface
     /// </summary>
    public partial interface IEligibilityEvaluationModel : IAutobahnBase
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
