//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationWIOA.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationWIOA
     /// </summary>
    public partial class ProgramParticipationWIOA : AutobahnBase, Interfaces.IProgramParticipationWIOA
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationWIOA.WIOACareerServices nullable property
        /// </summary>
        public System.Boolean? WIOACareerServices { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationWIOA.WIOATrainingServices nullable property
        /// </summary>
        public System.Boolean? WIOATrainingServices { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
