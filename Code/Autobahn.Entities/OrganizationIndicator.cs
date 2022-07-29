using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationIndicator")]
    public partial class OrganizationIndicator
    {
        public int OrganizationIndicatorId { get; set; }

        public int OrganizationId { get; set; }

        [Required]
        [StringLength(50)]
        public string IndicatorValue { get; set; }

        public int RefOrganizationIndicatorId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOrganizationIndicator RefOrganizationIndicator { get; set; }
    }
}
