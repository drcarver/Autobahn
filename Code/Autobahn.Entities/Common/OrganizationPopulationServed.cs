using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("OrganizationPopulationServed", Schema = "Common")]
    public partial class OrganizationPopulationServed
    {
        public int OrganizationPopulationServedId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(10)]
        public string AgeUnit { get; set; }

        public int? OldestAgeServed { get; set; }

        public int? YoungestAgeServed { get; set; }

        public int? RefPopulationServedId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPopulationServed RefPopulationServed { get; set; }
    }
}
