using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CourseSectionAssessmentReporting")]
    public partial class CourseSectionAssessmentReporting
    {
        public int CourseSectionAssessmentReportingId { get; set; }

        public int? CourseSectionId { get; set; }

        public int? RefCourseSectionAssessmentReportingMethodId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCourseSectionAssessmentReportingMethod RefCourseSectionAssessmentReportingMethod { get; set; }
    }
}