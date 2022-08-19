using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialAwardEvidence")]
    public partial class CredentialAwardEvidence
    {
        public int CredentialAwardEvidenceId { get; set; }

        public int CredentialAwardId { get; set; }

        [StringLength(300)]
        public string Statement { get; set; }

        public int? AssessmentResultId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual AssessmentResult AssessmentResult { get; set; }

        public virtual CredentialAward CredentialAward { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
