//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherStudentDataLinkExclusionModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusion Model
     /// </summary>
    public partial class TeacherStudentDataLinkExclusionModel : AutobahnBase, Interfaces.ITeacherStudentDataLinkExclusionModel
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
