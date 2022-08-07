//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   ProgramParticipationCteModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.CareerandTechnical.Models
{
     /// <summary>
     /// The ProgramParticipationCte Model
     /// </summary>
    public partial class ProgramParticipationCteModel : AutobahnBase, Interfaces.IProgramParticipationCteModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CteParticipant nullable property
        /// </summary>
        public System.Boolean? CteParticipant { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CteConcentrator nullable property
        /// </summary>
        public System.Boolean? CteConcentrator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CteCompleter nullable property
        /// </summary>
        public System.Boolean? CteCompleter { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.SingleParentOrSinglePregnantWoman nullable property
        /// </summary>
        public System.Boolean? SingleParentOrSinglePregnantWoman { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.DisplacedHomemakerIndicator nullable property
        /// </summary>
        public System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CteNonTraditionalCompletion nullable property
        /// </summary>
        public System.Boolean? CteNonTraditionalCompletion { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonTraditionalGenderStatus"/> model
        /// </summary>
        public Guid? RefNonTraditionalGenderStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CareerPathwaysProgramParticipationExitDate nullable property
        /// </summary>
        public System.DateTime? CareerPathwaysProgramParticipationExitDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CareerPathwaysProgramParticipationStartDate nullable property
        /// </summary>
        public System.DateTime? CareerPathwaysProgramParticipationStartDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.OutOfWorkforceIndicator nullable property
        /// </summary>
        public System.Boolean? OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
