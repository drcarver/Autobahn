//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTitleIIILep.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationTitleIIILep
     /// </summary>
    public partial class ProgramParticipationTitleIIILep : AutobahnBase, Interfaces.IProgramParticipationTitleIIILep
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
        /// Reference to a required instance of the <see cref="ProgramParticipationTitleIiiLep"/> model
        /// </summary>
        public Guid ProgramParticipationTitleIiiLepId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
