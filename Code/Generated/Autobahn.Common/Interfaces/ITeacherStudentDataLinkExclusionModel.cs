//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ITeacherStudentDataLinkExclusionModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ITeacherStudentDataLinkExclusionModel Interface
     /// </summary>
    public partial interface ITeacherStudentDataLinkExclusionModel : IAutobahnBase
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
