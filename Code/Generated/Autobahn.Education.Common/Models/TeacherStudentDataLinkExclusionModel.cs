//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherStudentDataLinkExclusionModel.cs
//* Name:       Teacher Student Data Link Exclusion Flag
//* Definition: Indicates that the student is excluded from calculation of value-added or growth attribution calculations used for teacher evaluation.
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// Teacher Student Data Link Exclusion Flag <see cref="TeacherStudentDataLinkExclusion"/>
     /// <para>
     /// Indicates that the student is excluded from calculation of value-added or growth attribution calculations used for teacher evaluation.
     /// </para>
     /// <para>
     /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19973">Teacher Student Data Link Exclusion Flag</a>
     /// </para>
     /// </summary>
    public partial class TeacherStudentDataLinkExclusionModel : ITeacherStudentDataLinkExclusion
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

        #region ITeacherStudentDataLinkExclusion
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12staffAssignment"/> model
        /// </summary>
        public Guid K12staffAssignmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
        /// </summary>
        public Guid K12studentCourseSectionId { get; set; }

        #endregion
    }
}
