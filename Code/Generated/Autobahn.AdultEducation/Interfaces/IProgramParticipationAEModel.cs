//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IProgramParticipationAEModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IProgramParticipationAEModel Interface
     /// </summary>
    public partial interface IProgramParticipationAEModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
        /// </summary>
        Guid? RefAeInstructionalProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
        /// </summary>
        Guid? RefAePostsecondaryTransitionActionId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.PostsecondaryTransitionDate nullable property
        /// </summary>
        System.DateTime? PostsecondaryTransitionDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
        /// </summary>
        Guid? RefAeSpecialProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
        /// </summary>
        Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
        /// </summary>
        Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
        /// </summary>
        Guid? RefGoalsForAttendingAdultEducationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.DisplacedHomemakerIndicator nullable property
        /// </summary>
        System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.ProxyContactHours nullable property
        /// </summary>
        System.Decimal? ProxyContactHours { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.InstructionalActivityHoursCompleted nullable property
        /// </summary>
        System.Decimal? InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
        /// </summary>
        Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.OutOfWorkforceIndicator nullable property
        /// </summary>
        System.Boolean? OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
        /// </summary>
        Guid? RefAdultEducationProgramExitReasonId { get; set; }

    }
}
