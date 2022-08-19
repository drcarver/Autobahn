using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12SchoolGradeLevelsApproved")]
    public partial class K12SchoolGradeLevelsApproved
    {
        public int K12SchoolGradeLevelsApprovedId { get; set; }

        public int K12SchoolId { get; set; }

        public int RefGradeLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12School K12School { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefGradeLevel RefGradeLevel { get; set; }
    }
}
