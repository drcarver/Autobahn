using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationOperationalStatus", Schema = "Common")]
    public partial class OrganizationOperationalStatus
    {
        [Key]
        public int OrganizationOperationalStatusId { get; set; }

        public Guid OrganizationId { get; set; }

        public int RefOperationalStatusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OperationalStatusEffectiveDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOperationalStatus RefOperationalStatus { get; set; }
    }
}
