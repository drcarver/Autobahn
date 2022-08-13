//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationNeglected.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IProgramParticipationNeglected Interface
     /// </summary>
    public partial interface IProgramParticipationNeglected : IAutobahnBase
    {
        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        System.Boolean? AchievementIndicator { get; set; }

        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        System.Boolean? ObtainedEmployment { get; set; }

        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        System.Boolean? OutcomeIndicator { get; set; }

        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
        /// </summary>
        Guid? RefNeglectedProgramTypeId { get; set; }

    }
}
