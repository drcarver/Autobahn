//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherStudentDataLinkExclusion.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusion
     /// </summary>
    public partial class TeacherStudentDataLinkExclusion : AutobahnBase, Interfaces.ITeacherStudentDataLinkExclusion
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12StudentCourseSection"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12StaffAssignment"/> model
        /// </summary>
        public Guid K12StaffAssignmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
