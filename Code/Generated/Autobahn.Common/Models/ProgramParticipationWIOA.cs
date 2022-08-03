//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationWIOA.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ProgramParticipationWIOA
     /// </summary>
    public partial class ProgramParticipationWIOA : IProgramParticipationWIOA
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
        /// Defines the ProgramParticipationWIOA.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationWIOA.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

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
