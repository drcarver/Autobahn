//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramEligibility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramEligibility Interface
     /// </summary>
    public partial interface IIndividualizedProgramEligibility : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ConsentToEvaluateDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ConsentToEvaluateIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ParentObservations { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
