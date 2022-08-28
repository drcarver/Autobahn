//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentDisciplineModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12studentDiscipline Model
     /// </summary>
    public partial class K12studentDisciplineModel : IK12studentDiscipline
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

        #region IK12studentDiscipline
        public DateTime? DisciplinaryActionEndDate { get; set; }

        public DateTime? DisciplinaryActionStartDate { get; set; }

        public Decimal? DurationOfDisciplinaryAction { get; set; }

        public Boolean? EducationalServicesAfterRemoval { get; set; }

        public Boolean? FullYearExpulsion { get; set; }

        public Boolean? IepplacementMeetingIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIncident"/> model
        /// </summary>
        public Guid? IncidentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
        /// </summary>
        public Guid? RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
        /// </summary>
        public Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
        /// </summary>
        public Guid? RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
        /// </summary>
        public Guid? RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
        /// </summary>
        public Guid? RefDisciplineReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeadisciplineMethodFirearm"/> model
        /// </summary>
        public Guid? RefIdeadisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalReasonId { get; set; }

        public Boolean? RelatedToZeroTolerancePolicy { get; set; }

        public Boolean? ShortenedExpulsion { get; set; }

        #endregion
    }
}
