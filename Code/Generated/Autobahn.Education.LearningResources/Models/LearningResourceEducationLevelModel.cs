//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceEducationLevelModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.LearningResources;

namespace Autobahn.Education.LearningResources.Models
{
     /// <summary>
     /// The LearningResourceEducationLevel Model
     /// </summary>
    public partial class LearningResourceEducationLevelModel : ILearningResourceEducationLevel
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

        #region ILearningResourceEducationLevel
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Learning Resource Education Level�
        /// <para>
        /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20212">Learning Resource Education Level�</a>
        /// </para>
        /// </summary>
        public Guid RefEducationLevelId { get; set; }

        #endregion
    }
}
