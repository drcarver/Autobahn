//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   IProgramParticipationCteModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CareerandTechnical.Interfaces
{
     /// <summary>
     /// The IProgramParticipationCteModel Interface
     /// </summary>
    public partial interface IProgramParticipationCteModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CteParticipant nullable property
        /// </summary>
        System.Boolean? CteParticipant { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CteConcentrator nullable property
        /// </summary>
        System.Boolean? CteConcentrator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CteCompleter nullable property
        /// </summary>
        System.Boolean? CteCompleter { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.SingleParentOrSinglePregnantWoman nullable property
        /// </summary>
        System.Boolean? SingleParentOrSinglePregnantWoman { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.DisplacedHomemakerIndicator nullable property
        /// </summary>
        System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CteNonTraditionalCompletion nullable property
        /// </summary>
        System.Boolean? CteNonTraditionalCompletion { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonTraditionalGenderStatus"/> model
        /// </summary>
        Guid? RefNonTraditionalGenderStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CareerPathwaysProgramParticipationExitDate nullable property
        /// </summary>
        System.DateTime? CareerPathwaysProgramParticipationExitDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.CareerPathwaysProgramParticipationStartDate nullable property
        /// </summary>
        System.DateTime? CareerPathwaysProgramParticipationStartDate { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationCte.OutOfWorkforceIndicator nullable property
        /// </summary>
        System.Boolean? OutOfWorkforceIndicator { get; set; }

    }
}
