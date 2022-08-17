//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherStudentDataLinkExclusionModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusion Model
     /// </summary>
    public partial class TeacherStudentDataLinkExclusionModel : AutobahnBase, Interfaces.ITeacherStudentDataLinkExclusion
    {
        /// <summary>
        /// Teaching Assignment Contribution Percentage
        /// <para>
        /// A percentage used to weight the educator's assigned responsibility for student learning in a Class Section, particularly when more than one educator is assigned to the class section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19651">Teaching Assignment Contribution Percentage</a>
        /// </para>
        /// </summary>
        public Guid K12StaffAssignmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12StudentCourseSection"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get; set; }

    }
}
