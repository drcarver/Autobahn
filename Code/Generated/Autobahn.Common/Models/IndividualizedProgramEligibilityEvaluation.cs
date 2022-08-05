//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramEligibilityEvaluation.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluation
     /// </summary>
    public partial class IndividualizedProgramEligibilityEvaluation : AutobahnBase, Interfaces.IIndividualizedProgramEligibilityEvaluation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="EligibilityEvaluation"/> model
        /// </summary>
        public Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramEligibility"/> model
        /// </summary>
        public Guid IndividualizedProgramEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPEligibilityEvaluationType"/> model
        /// </summary>
        public Guid? RefIEPEligibilityEvaluationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
