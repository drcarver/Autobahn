//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationTitleIModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationTitleI Model
     /// </summary>
    public partial class ProgramParticipationTitleIModel : AutobahnBase, Interfaces.IProgramParticipationTitleI
    {
        /// <summary>
        /// An indication that the student is participating in and served by programs under Title I, Part A of ESEA as amended.
        /// </summary>
        public Guid? RefTitleIIndicatorId { get; set; }

    }
}
