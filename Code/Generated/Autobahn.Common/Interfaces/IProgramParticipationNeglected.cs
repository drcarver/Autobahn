//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationNeglected.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationNeglected
     /// </summary>
    public partial interface IProgramParticipationNeglected : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeglectedProgramType"/> model
        /// </summary>
        Guid? RefNeglectedProgramTypeId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationNeglected.AchievementIndicator nullable property
        /// </summary>
        System.Boolean? AchievementIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationNeglected.OutcomeIndicator nullable property
        /// </summary>
        System.Boolean? OutcomeIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationNeglected.ObtainedEmployment nullable property
        /// </summary>
        System.Boolean? ObtainedEmployment { get; set; }

    }
}
