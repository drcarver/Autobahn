using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AeCourse")]
    public partial class AeCourse
    {
        public int AeCourseId { get; set; }

        public Guid OrganizationId { get; set; }

        public int? RefCourseLevelTypeId { get; set; }

        public int? RefCareerClusterId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCareerCluster RefCareerCluster { get; set; }
    }
}
