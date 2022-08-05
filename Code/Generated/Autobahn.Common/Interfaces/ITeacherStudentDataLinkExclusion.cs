//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ITeacherStudentDataLinkExclusion.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ITeacherStudentDataLinkExclusion
     /// </summary>
    public partial interface ITeacherStudentDataLinkExclusion : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12StudentCourseSection"/> model
        /// </summary>
        Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12StaffAssignment"/> model
        /// </summary>
        Guid K12StaffAssignmentId { get; set; }

    }
}
