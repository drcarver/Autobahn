using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationTelephone")]
    public partial class OrganizationTelephone
    {
        public int OrganizationTelephoneId { get; set; }

        public int OrganizationId { get; set; }

        [Required]
        [StringLength(24)]
        public string TelephoneNumber { get; set; }

        public bool PrimaryTelephoneNumberIndicator { get; set; }

        public int? RefInstitutionTelephoneTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public bool? DoNotPublishIndicator { get; set; }

        public int? RefTelephoneNumberListedStatusId { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefInstitutionTelephoneType RefInstitutionTelephoneType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefTelephoneNumberListedStatus RefTelephoneNumberListedStatus { get; set; }
    }
}
