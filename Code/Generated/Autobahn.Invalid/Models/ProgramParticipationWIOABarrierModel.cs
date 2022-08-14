//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationWIOABarrierModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationWIOABarrier Model
     /// </summary>
    public partial class ProgramParticipationWIOABarrierModel : AutobahnBase, Interfaces.IProgramParticipationWIOABarrier
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid ProgramParticipationWIOABarriersId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ProgramParticipationWIOAId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefWIOABarrierstoEmploymentId { get; set; }

    }
}
