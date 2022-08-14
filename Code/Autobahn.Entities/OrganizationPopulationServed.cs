using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("OrganizationPopulationServed")]
    public partial class OrganizationPopulationServed
    {
        public int OrganizationPopulationServedId { get; set; }

        public int OrganizationId { get; set; }

        [StringLength(10)]
        public string AgeUnit { get; set; }

        public int? OldestAgeServed { get; set; }

        public int? YoungestAgeServed { get; set; }

        public int? RefPopulationServedId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPopulationServed RefPopulationServed { get; set; }
    }
}
