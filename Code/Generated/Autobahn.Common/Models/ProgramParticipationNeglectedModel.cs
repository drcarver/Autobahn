//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationNeglectedModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationNeglected Model
     /// </summary>
    public partial class ProgramParticipationNeglectedModel : AutobahnBase, Interfaces.IProgramParticipationNeglectedModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeglectedProgramType"/> model
        /// </summary>
        public Guid? RefNeglectedProgramTypeId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationNeglected.AchievementIndicator nullable property
        /// </summary>
        public System.Boolean? AchievementIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationNeglected.OutcomeIndicator nullable property
        /// </summary>
        public System.Boolean? OutcomeIndicator { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationNeglected.ObtainedEmployment nullable property
        /// </summary>
        public System.Boolean? ObtainedEmployment { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
