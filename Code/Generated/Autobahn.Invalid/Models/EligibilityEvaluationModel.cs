//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   EligibilityEvaluationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The EligibilityEvaluation Model
     /// </summary>
    public partial class EligibilityEvaluationModel : AutobahnBase, Interfaces.IEligibilityEvaluation
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EvaluationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
