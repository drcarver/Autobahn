//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgramAssessment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramAssessment Interface
     /// </summary>
    public partial interface IIndividualizedProgramAssessment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? IEPAlternativeAssessmentRationale { get; set; }

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
