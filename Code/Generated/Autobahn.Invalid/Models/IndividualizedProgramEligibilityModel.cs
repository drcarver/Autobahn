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
        /// 
        /// </summary>
        public  ConsentToEvaluateDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ConsentToEvaluateIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParentObservations { get; set; }

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
