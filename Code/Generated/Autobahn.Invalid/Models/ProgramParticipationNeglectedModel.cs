//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationNeglectedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationNeglected Model
     /// </summary>
    public partial class ProgramParticipationNeglectedModel : AutobahnBase, Interfaces.IProgramParticipationNeglected
    {
        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        public Guid? RefNeglectedProgramTypeId { get; set; }

    }
}
