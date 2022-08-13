//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherStudentDataLinkExclusionModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusion Model
     /// </summary>
    public partial class TeacherStudentDataLinkExclusionModel : AutobahnBase, Interfaces.ITeacherStudentDataLinkExclusion
    {
        /// <summary>
        /// Indicates that the student is excluded from calculation of value-added or growth attribution calculations used for teacher evaluation.
        /// </summary>
        public Guid K12StaffAssignmentId { get; set; }

        /// <summary>
        /// Indicates that the student is excluded from calculation of value-added or growth attribution calculations used for teacher evaluation.
        /// </summary>
        public Guid K12StudentCourseSectionId { get; set; }

    }
}
