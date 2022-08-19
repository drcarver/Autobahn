using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELEnrollmentOtherFunding")]
    public partial class ELEnrollmentOtherFunding
    {
        public int ELEnrollmentOtherFundingId { get; set; }

        public int PersonId { get; set; }

        public int RefELOtherFederalFundingSourcesId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
