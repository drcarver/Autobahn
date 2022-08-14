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
        /// The type of Title III language instructional education programs.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        public Guid ProgramParticipationTitleIiiLepId { get; set; }

        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        public Guid? RefTitleIIIAccountabilityId { get; set; }

        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        public Guid? RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
