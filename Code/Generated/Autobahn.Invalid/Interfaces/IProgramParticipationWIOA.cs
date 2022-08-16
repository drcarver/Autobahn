//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationWIOA.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationWIOA Interface
     /// </summary>
    public partial interface IProgramParticipationWIOA : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         WIOACareerServices { get; set; }

        /// <summary>
        /// 
        /// </summary>
         WIOATrainingServices { get; set; }

    }
}
