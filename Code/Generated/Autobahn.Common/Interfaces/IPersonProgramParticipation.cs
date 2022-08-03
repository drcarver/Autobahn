//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonProgramParticipation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonProgramParticipation
     /// </summary>
    public partial interface IPersonProgramParticipation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationType"/> model
        /// </summary>
        Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramExitReason"/> model
        /// </summary>
        Guid? RefProgramExitReasonId { get; set; }

        /// <summary>
        /// Defines the PersonProgramParticipation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonProgramParticipation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PersonProgramParticipation.ParticipationStatus non nullable property
        /// </summary>
        System.String ParticipationStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramEntryReason"/> model
        /// </summary>
        Guid? RefProgramEntryReasonId { get; set; }

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
