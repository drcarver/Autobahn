//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentGraduationPlanModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12studentGraduationPlan Model
     /// </summary>
    public partial class K12studentGraduationPlanModel : IK12studentGraduationPlan
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

        #region IK12studentGraduationPlan
        public Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12course"/> model
        /// </summary>
        public Guid K12courseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
        /// </summary>
        public Guid? RefScedcourseSubjectAreaId { get; set; }

        #endregion
    }
}