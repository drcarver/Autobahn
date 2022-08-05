//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonProgramParticipation.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonProgramParticipation
     /// </summary>
    public partial class PersonProgramParticipation : AutobahnBase, Interfaces.IPersonProgramParticipation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationType"/> model
        /// </summary>
        public Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramExitReason"/> model
        /// </summary>
        public Guid? RefProgramExitReasonId { get; set; }

        /// <summary>
        /// Defines the PersonProgramParticipation.ParticipationStatus non nullable property
        /// </summary>
        public System.String ParticipationStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramEntryReason"/> model
        /// </summary>
        public Guid? RefProgramEntryReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
