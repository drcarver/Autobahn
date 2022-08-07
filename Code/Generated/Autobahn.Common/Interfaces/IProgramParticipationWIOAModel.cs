//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationWIOAModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationWIOAModel Interface
     /// </summary>
    public partial interface IProgramParticipationWIOAModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationWIOA.WIOACareerServices nullable property
        /// </summary>
        System.Boolean? WIOACareerServices { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationWIOA.WIOATrainingServices nullable property
        /// </summary>
        System.Boolean? WIOATrainingServices { get; set; }

    }
}
