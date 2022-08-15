//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationMigrantModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationMigrant Model
     /// </summary>
    public partial class ProgramParticipationMigrantModel : AutobahnBase, Interfaces.IProgramParticipationMigrant
    {
        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        public System.DateTime? LastQualifyingMoveDate { get; set; }

    }
}
