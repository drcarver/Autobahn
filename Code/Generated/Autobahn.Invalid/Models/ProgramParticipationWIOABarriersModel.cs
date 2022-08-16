//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationWIOABarriersModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationWIOABarriers Model
     /// </summary>
    public partial class ProgramParticipationWIOABarriersModel : AutobahnBase, Interfaces.IProgramParticipationWIOABarriers
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefWIOABarrierstoEmploymentId { get; set; }

    }
}
