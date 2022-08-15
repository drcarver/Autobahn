//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationMigrant.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IProgramParticipationMigrant Interface
     /// </summary>
    public partial interface IProgramParticipationMigrant : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </summary>
        System.DateTime? LastQualifyingMoveDate { get; set; }

    }
}
