//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   ProgramParticipationAEModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The ProgramParticipationAE Model
     /// </summary>
    public partial class ProgramParticipationAEModel : AutobahnBase, Interfaces.IProgramParticipationAEModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
        /// </summary>
        public Guid? RefAeInstructionalProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
        /// </summary>
        public Guid? RefAePostsecondaryTransitionActionId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.PostsecondaryTransitionDate nullable property
        /// </summary>
        public System.DateTime? PostsecondaryTransitionDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
        /// </summary>
        public Guid? RefAeSpecialProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
        /// </summary>
        public Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
        /// </summary>
        public Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
        /// </summary>
        public Guid? RefGoalsForAttendingAdultEducationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.DisplacedHomemakerIndicator nullable property
        /// </summary>
        public System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.ProxyContactHours nullable property
        /// </summary>
        public System.Decimal? ProxyContactHours { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.InstructionalActivityHoursCompleted nullable property
        /// </summary>
        public System.Decimal? InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
        /// </summary>
        public Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationAE.OutOfWorkforceIndicator nullable property
        /// </summary>
        public System.Boolean? OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
        /// </summary>
        public Guid? RefAdultEducationProgramExitReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
