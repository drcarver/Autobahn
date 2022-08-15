//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ProgramParticipationCteModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.CTE.Models
{
     /// <summary>
     /// The ProgramParticipationCte Model
     /// </summary>
    public partial class ProgramParticipationCteModel : AutobahnBase, Interfaces.IProgramParticipationCte
    {
        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.Boolean? CteCompleter { get; set; }

    }
}
