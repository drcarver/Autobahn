//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   ITeacherStudentDataLinkExclusion.cs
//* Name:       Teacher Student Data Link Exclusion Flag
//* Definition: Indicates that the student is excluded from calculation of value-added or growth attribution calculations used for teacher evaluation.
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
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
    public partial interface ITeacherStudentDataLinkExclusion : IAutobahnBase
    {
        #region ITeacherStudentDataLinkExclusion
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12staffAssignment"/> model
        /// </summary>
        Guid K12staffAssignmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12studentCourseSection"/> model
        /// </summary>
        Guid K12studentCourseSectionId { get; set; }

        #endregion
    }
}
