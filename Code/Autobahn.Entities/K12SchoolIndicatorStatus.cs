using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12SchoolIndicatorStatus")]
    public partial class K12SchoolIndicatorStatus
    {
        public int K12SchoolIndicatorStatusId { get; set; }

        public int K12SchoolId { get; set; }

        public int RefIndicatorStatusTypeId { get; set; }

        public int? RefIndicatorStateDefinedStatusId { get; set; }

        public int? RefIndicatorStatusSubgroupTypeId { get; set; }

        [StringLength(100)]
        public string IndicatorStatusSubgroup { get; set; }

        [StringLength(100)]
        public string IndicatorStatus { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RefIndicatorStatusCustomTypeId { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12School K12School { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIndicatorStateDefinedStatus RefIndicatorStateDefinedStatus { get; set; }

        public virtual RefIndicatorStatusCustomType RefIndicatorStatusCustomType { get; set; }

        public virtual RefIndicatorStatusSubgroupType RefIndicatorStatusSubgroupType { get; set; }

        public virtual RefIndicatorStatusType RefIndicatorStatusType { get; set; }
    }
}
