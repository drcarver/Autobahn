//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ITeacherStudentDataLinkExclusion.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ITeacherStudentDataLinkExclusion
     /// </summary>
    public partial interface ITeacherStudentDataLinkExclusion
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12StudentCourseSection"/> model
        /// </summary>
        Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12StaffAssignment"/> model
        /// </summary>
        Guid K12StaffAssignmentId { get; set; }

        /// <summary>
        /// Defines the TeacherStudentDataLinkExclusion.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the TeacherStudentDataLinkExclusion.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
