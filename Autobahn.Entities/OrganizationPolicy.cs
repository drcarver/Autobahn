using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationPolicy")]
    public partial class OrganizationPolicy
    {
        public int OrganizationPolicyId { get; set; }

        public int OrganizationId { get; set; }

        [Required]
        [StringLength(100)]
        public string PolicyType { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
