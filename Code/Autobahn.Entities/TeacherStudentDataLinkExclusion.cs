using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("TeacherStudentDataLinkExclusion")]
    public partial class TeacherStudentDataLinkExclusion
    {
        public int TeacherStudentDataLinkExclusionId { get; set; }

        public int K12StudentCourseSectionId { get; set; }

        public int K12StaffAssignmentId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12StaffAssignment K12StaffAssignment { get; set; }

        public virtual K12StudentCourseSection K12StudentCourseSection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
