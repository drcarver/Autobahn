//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationTitleIIILepModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationTitleIIILepModel Interface
     /// </summary>
    public partial interface IProgramParticipationTitleIIILepModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIIAccountability"/> model
        /// </summary>
        Guid? RefTitleIIIAccountabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        Guid? RefTitleIIILanguageInstructionProgramTypeId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationTitleIiiLep"/> model
        /// </summary>
        Guid ProgramParticipationTitleIiiLepId { get; set; }

    }
}
