//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationNeglected.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationNeglected
     /// </summary>
    public partial interface IProgramParticipationNeglected
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

        /// <summary>
        /// Defines the ProgramParticipationNeglected.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationNeglected.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
