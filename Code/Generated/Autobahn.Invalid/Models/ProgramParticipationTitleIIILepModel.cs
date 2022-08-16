//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationTitleIIILepModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationTitleIIILep Model
     /// </summary>
    public partial class ProgramParticipationTitleIIILepModel : AutobahnBase, Interfaces.IProgramParticipationTitleIIILep
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTitleIIIAccountabilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
