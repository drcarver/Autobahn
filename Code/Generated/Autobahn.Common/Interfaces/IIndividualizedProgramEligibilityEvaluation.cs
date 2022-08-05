//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramEligibilityEvaluation.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibilityEvaluation
     /// </summary>
    public partial interface IIndividualizedProgramEligibilityEvaluation : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="EligibilityEvaluation"/> model
        /// </summary>
        Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramEligibility"/> model
        /// </summary>
        Guid IndividualizedProgramEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPEligibilityEvaluationType"/> model
        /// </summary>
        Guid? RefIEPEligibilityEvaluationTypeId { get; set; }

    }
}
