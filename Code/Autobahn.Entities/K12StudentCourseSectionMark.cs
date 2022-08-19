using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12StudentCourseSectionMark")]
    public partial class K12StudentCourseSectionMark
    {
        public int K12StudentCourseSectionMarkId { get; set; }

        public int K12StudentCourseSectionId { get; set; }

        [StringLength(30)]
        public string MarkingPeriodName { get; set; }

        public bool? FinalIndicator { get; set; }

        [StringLength(15)]
        public string GradeEarned { get; set; }

        [StringLength(15)]
        public string MidTermMark { get; set; }

        [StringLength(100)]
        public string GradeValueQualifier { get; set; }

        [StringLength(300)]
        public string StudentCourseSectionGradeNarrative { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12StudentCourseSection K12StudentCourseSection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
