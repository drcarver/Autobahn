//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramEligibilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramEligibility Model
     /// </summary>
    public partial class IndividualizedProgramEligibilityModel : AutobahnBase, Interfaces.IIndividualizedProgramEligibility
    {
        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        public System.Boolean? ConsentToEvaluateIndicator { get; set; }

    }
}
