//***************************************************************************
//* DomainName: Career and Technical Education (CTE) Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationCte.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CTE.Interfaces
{
     /// <summary>
     /// The IProgramParticipationCte Interface
     /// </summary>
    public partial interface IProgramParticipationCte : IAutobahnBase
    {
        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.Boolean? CteCompleter { get; set; }

    }
}
