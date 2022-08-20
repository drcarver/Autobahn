using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationIndicator", Schema = "Common")]
    public partial class OrganizationIndicator
    {
        public int OrganizationIndicatorId { get; set; }

        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(50)]
        public string IndicatorValue { get; set; }

        public int RefOrganizationIndicatorId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOrganizationIndicator RefOrganizationIndicator { get; set; }
    }
}
