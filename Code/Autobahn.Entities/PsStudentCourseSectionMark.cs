using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsStudentCourseSectionMark")]
    public partial class PsStudentCourseSectionMark
    {
        public int PsStudentCourseSectionMarkId { get; set; }

        public int PsStudentSectionId { get; set; }

        [StringLength(300)]
        public string CourseNarrativeExplanationGrade { get; set; }

        [StringLength(300)]
        public string StudentCourseSectionGradeNarrative { get; set; }

        public int? RefCourseAcademicGradeStatusCodeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual PsStudentSection PsStudentSection { get; set; }
    }
}
