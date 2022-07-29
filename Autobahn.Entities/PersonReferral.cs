using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonReferral")]
    public partial class PersonReferral
    {
        public int PersonReferralId { get; set; }

        public int PersonId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReferralDate { get; set; }

        public string Reason { get; set; }

        [StringLength(60)]
        public string Source { get; set; }

        [StringLength(60)]
        public string ReferralTypeReceived { get; set; }

        [StringLength(60)]
        public string ReferredTo { get; set; }

        public int? RefReferralOutcomeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefReferralOutcome RefReferralOutcome { get; set; }
    }
}
