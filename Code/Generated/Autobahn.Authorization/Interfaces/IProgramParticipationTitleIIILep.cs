//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationTitleIIILep.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTitleIIILep Interface
     /// </summary>
    public partial interface IProgramParticipationTitleIIILep : IAutobahnBase
    {
        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        Guid ProgramParticipationTitleIiiLepId { get; set; }

        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        Guid? RefTitleIIIAccountabilityId { get; set; }

        /// <summary>
        /// The type of Title III language instructional education programs.
        /// </summary>
        Guid? RefTitleIIILanguageInstructionProgramTypeId { get; set; }

    }
}
