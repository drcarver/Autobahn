//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationTitleI.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTitleI Interface
     /// </summary>
    public partial interface IProgramParticipationTitleI : IAutobahnBase
    {
        /// <summary>
        /// An indication that the student is participating in and served by programs under Title I, Part A of ESEA as amended.
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// An indication that the student is participating in and served by programs under Title I, Part A of ESEA as amended.
        /// </summary>
        Guid? RefTitleIIndicatorId { get; set; }

    }
}
