//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The PersonProgramParticipation Model
     /// </summary>
    public partial class PersonProgramParticipationModel : AutobahnBase, Interfaces.IPersonProgramParticipation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Gifted and Talented Indicator
        /// <para>
        /// An indication that the student is participating in and served by a Gifted/Talented program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19122">Gifted and Talented Indicator</a>
        /// </para>
        /// </summary>
        public System.String ParticipationStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefParticipationType"/> model
        /// </summary>
        public Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProgramEntryReason"/> model
        /// </summary>
        public Guid? RefProgramEntryReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProgramExitReason"/> model
        /// </summary>
        public Guid? RefProgramExitReasonId { get; set; }

    }
}
