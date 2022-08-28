//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The PersonProgramParticipation Model
     /// </summary>
    public partial class PersonProgramParticipationModel : IPersonProgramParticipation
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IPersonProgramParticipation
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
        /// GED Preparation Program Participation Status
        /// <para>
        /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19120">GED Preparation Program Participation Status</a>
        /// </para>
        /// </summary>
        public Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// Program Entry Reason
        /// <para>
        /// The documented or assumed reason a person is being served by a program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20909">Program Entry Reason</a>
        /// </para>
        /// </summary>
        public Guid? RefProgramEntryReasonId { get; set; }

        /// <summary>
        /// Exit Reason
        /// <para>
        /// The documented or assumed reason a student is no longer being served by a special program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19222">Exit Reason</a>
        /// </para>
        /// </summary>
        public Guid? RefProgramExitReasonId { get; set; }

        #endregion
    }
}
