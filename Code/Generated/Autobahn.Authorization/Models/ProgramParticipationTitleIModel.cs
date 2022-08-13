//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramParticipationTitleIModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ProgramParticipationTitleI Model
     /// </summary>
    public partial class ProgramParticipationTitleIModel : AutobahnBase, Interfaces.IProgramParticipationTitleI
    {
        /// <summary>
        /// An indication that the student is participating in and served by programs under Title I, Part A of ESEA as amended.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// An indication that the student is participating in and served by programs under Title I, Part A of ESEA as amended.
        /// </summary>
        public Guid? RefTitleIIndicatorId { get; set; }

    }
}
