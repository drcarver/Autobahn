//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherStudentDataLinkExclusion.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusion
     /// </summary>
    public partial class TeacherStudentDataLinkExclusion : ITeacherStudentDataLinkExclusion
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
        /// Defines the TeacherStudentDataLinkExclusion.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the TeacherStudentDataLinkExclusion.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
