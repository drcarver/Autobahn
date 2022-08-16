//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IEligibilityEvaluation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IEligibilityEvaluation Interface
     /// </summary>
    public partial interface IEligibilityEvaluation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EvaluationDate { get; set; }

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
