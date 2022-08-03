//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramParticipationWIOA.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramParticipationWIOA
     /// </summary>
    public partial interface IProgramParticipationWIOA
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

        /// <summary>
        /// Defines the ProgramParticipationWIOA.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ProgramParticipationWIOA.RecordEndDateTime nullable property
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
