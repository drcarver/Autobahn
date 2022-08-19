using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CredentialAwardCredit")]
    public partial class CredentialAwardCredit
    {
        public int CredentialAwardCreditId { get; set; }

        public int CredentialAwardId { get; set; }

        public int? CredentialCriteriaCourseId { get; set; }

        public int? OrganizationPersonRoleId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual CredentialAward CredentialAward { get; set; }

        public virtual CredentialCriteriaCourse CredentialCriteriaCourse { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
