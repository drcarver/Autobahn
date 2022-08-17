//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonProgramParticipation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonProgramParticipation Interface
     /// </summary>
    public partial interface IPersonProgramParticipation : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Gifted and Talented Indicator
        /// <para>
        /// An indication that the student is participating in and served by a Gifted/Talented program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19122">Gifted and Talented Indicator</a>
        /// </para>
        /// </summary>
        System.String ParticipationStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefParticipationType"/> model
        /// </summary>
        Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProgramEntryReason"/> model
        /// </summary>
        Guid? RefProgramEntryReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProgramExitReason"/> model
        /// </summary>
        Guid? RefProgramExitReasonId { get; set; }

    }
}
