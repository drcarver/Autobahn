//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCourseSectionMarkModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12studentCourseSectionMark Model
     /// </summary>
    public partial class K12studentCourseSectionMarkModel : IK12studentCourseSectionMark
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

        #region IK12studentCourseSectionMark
        public Boolean? FinalIndicator { get; set; }

        public System.String GradeEarned { get; set; }

        public System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
        /// </summary>
        public Guid K12studentCourseSectionId { get; set; }

        public System.String MarkingPeriodName { get; set; }

        public System.String MidTermMark { get; set; }

        public System.String StudentCourseSectionGradeNarrative { get; set; }

        #endregion
    }
}
