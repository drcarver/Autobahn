using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CourseSectionLocation")]
    public partial class CourseSectionLocation
    {
        public int CourseSectionLocationId { get; set; }

        public int ClassroomId { get; set; }

        public int CourseSectionId { get; set; }

        public int? RefInstructionLocationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual Classroom Classroom { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefInstructionLocationType RefInstructionLocationType { get; set; }
    }
}
