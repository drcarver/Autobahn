//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramEligibilityEvaluationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluation Model
     /// </summary>
    public partial class IndividualizedProgramEligibilityEvaluationModel : AutobahnBase, Interfaces.IIndividualizedProgramEligibilityEvaluation
    {
        /// <summary>
        /// Purpose within the IEP lifecycle for which the eligibility evaluation is conducted.
        /// </summary>
        public Guid EligibilityEvaluationId { get; set; }

        /// <summary>
        /// Purpose within the IEP lifecycle for which the eligibility evaluation is conducted.
        /// </summary>
        public Guid IndividualizedProgramEligibilityId { get; set; }

        /// <summary>
        /// Purpose within the IEP lifecycle for which the eligibility evaluation is conducted.
        /// </summary>
        public Guid? RefIEPEligibilityEvaluationTypeId { get; set; }

    }
}
