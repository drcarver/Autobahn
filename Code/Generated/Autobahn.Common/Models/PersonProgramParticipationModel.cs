//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonProgramParticipation Model
     /// </summary>
    public partial class PersonProgramParticipationModel : AutobahnBase, Interfaces.IPersonProgramParticipation
    {
        /// <summary>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </summary>
        public System.String ParticipationStatus { get; set; }

        /// <summary>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </summary>
        public Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </summary>
        public Guid? RefProgramEntryReasonId { get; set; }

        /// <summary>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </summary>
        public Guid? RefProgramExitReasonId { get; set; }

    }
}
