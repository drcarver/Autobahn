//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramEligibilityEvaluationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramEligibilityEvaluation Model
     /// </summary>
    public partial class IndividualizedProgramEligibilityEvaluationModel : AutobahnBase, Interfaces.IIndividualizedProgramEligibilityEvaluation
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefIEPEligibilityEvaluationTypeId { get; set; }

    }
}
