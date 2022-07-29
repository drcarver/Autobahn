using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CourseSectionSchedule")]
    public partial class CourseSectionSchedule
    {
        public int CourseSectionScheduleId { get; set; }

        public int CourseSectionId { get; set; }

        [StringLength(60)]
        public string ClassMeetingDays { get; set; }

        public TimeSpan? ClassBeginningTime { get; set; }

        public TimeSpan? ClassEndingTime { get; set; }

        [StringLength(30)]
        public string ClassPeriod { get; set; }

        [StringLength(40)]
        public string TimeDayIdentifier { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
