//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationWIOABarrier.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProgramParticipationWIOABarrier Interface
     /// </summary>
    public partial interface IProgramParticipationWIOABarrier : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid ProgramParticipationWIOABarriersId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid ProgramParticipationWIOAId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefWIOABarrierstoEmploymentId { get; set; }

    }
}