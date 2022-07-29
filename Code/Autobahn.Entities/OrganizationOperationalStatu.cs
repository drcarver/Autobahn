using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    public partial class OrganizationOperationalStatu
    {
        [Key]
        public int OrganizationOperationalStatusId { get; set; }

        public int OrganizationId { get; set; }

        public int RefOperationalStatusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OperationalStatusEffectiveDate { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefOperationalStatu RefOperationalStatu { get; set; }
    }
}
