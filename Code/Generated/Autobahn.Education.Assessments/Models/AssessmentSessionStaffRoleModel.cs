//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionStaffRoleModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The AssessmentSessionStaffRole Model
     /// </summary>
    public partial class AssessmentSessionStaffRoleModel : IAssessmentSessionStaffRole
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

        #region IAssessmentSessionStaffRole
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
        /// </summary>
        public Guid? AssessmentParticipantSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
        /// </summary>
        public Guid? AssessmentSessionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Assessment Session Staff Role Type
        /// <para>
        /// The type of role served related to the administration of an assessment session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
        /// </para>
        /// </summary>
        public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

        #endregion
    }
}
