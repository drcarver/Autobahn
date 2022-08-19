using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELServicePartner")]
    public partial class ELServicePartner
    {
        public int ELServicePartnerId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(100)]
        public string ServicePartnerName { get; set; }

        [StringLength(300)]
        public string ServicePartnerDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MemorandumOfUnderstandingEndDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MemorandumOfUnderstandingStartDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
