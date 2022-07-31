//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   IWorkforceProgramParticipation.cs
//**********************************************************

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IWorkforceProgramParticipation
     /// </summary>
    public partial Interface IWorkforceProgramParticipation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="WorkforceProgramParticipation"/> model
        /// </summary>
        Guid WorkforceProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipation"/> model
        /// </summary>
        Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipation.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWfProgramParticipation"/> model
        /// </summary>
        Guid? RefWfProgramParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the WorkforceProgramParticipation.RecordEndDateTime nullable property
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
