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
        public System.DateTime? CareerPathwaysProgramParticipationExitDate { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.DateTime? CareerPathwaysProgramParticipationStartDate { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.Boolean? CteCompleter { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.Boolean? CteConcentrator { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.Boolean? CteNonTraditionalCompletion { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.Boolean? CteParticipant { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.Boolean? OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public Guid? RefNonTraditionalGenderStatusId { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// </summary>
        public System.Boolean? SingleParentOrSinglePregnantWoman { get; set; }

    }
}
