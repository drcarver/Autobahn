//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationWIOABarriers.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationWIOABarriers Interface
     /// </summary>
    public partial interface IProgramParticipationWIOABarriers : IAutobahnBase
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
         RefWIOABarrierstoEmploymentId { get; set; }

    }
}
