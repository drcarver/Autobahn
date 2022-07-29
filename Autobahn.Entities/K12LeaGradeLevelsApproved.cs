using System;

namespace Autobahn.Entities
{
    public partial class K12LeaGradeLevelsApproved
    {
        public int K12LeaGradeLevelsApprovedId { get; set; }

        public int K12LeaId { get; set; }

        public int RefGradeLevelId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12Lea K12Lea { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefGradeLevel RefGradeLevel { get; set; }
    }
}
