//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTitleIIILep.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationTitleIIILep
     /// </summary>
    public partial class ProgramParticipationTitleIIILep : IProgramParticipationTitleIIILep
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIIAccountability"/> model
        /// </summary>
        public Guid? RefTitleIIIAccountabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        public Guid? RefTitleIIILanguageInstructionProgramTypeId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTitleIIILep.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationTitleIIILep.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationTitleIiiLep"/> model
        /// </summary>
        public Guid ProgramParticipationTitleIiiLepId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
