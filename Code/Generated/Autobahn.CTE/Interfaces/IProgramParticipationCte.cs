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
        System.DateTime? CareerPathwaysProgramParticipationExitDate { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.DateTime? CareerPathwaysProgramParticipationStartDate { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.Boolean? CteCompleter { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.Boolean? CteConcentrator { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.Boolean? CteNonTraditionalCompletion { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.Boolean? CteParticipant { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.Boolean? OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        Guid? RefNonTraditionalGenderStatusId { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        System.Boolean? SingleParentOrSinglePregnantWoman { get; set; }

    }
}
