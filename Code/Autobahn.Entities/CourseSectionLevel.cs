using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CourseSectionLevel")]
    public partial class CourseSectionLevel
    {
        public int CourseSectionLevelId { get; set; }

        public int CourseSectionId { get; set; }

        public int RefCourseLevelTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCourseLevelType RefCourseLevelType { get; set; }
    }
}
