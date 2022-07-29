using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELClassSectionService")]
    public partial class ELClassSectionService
    {
        public int ELClassSectionServiceId { get; set; }

        public int ELClassSectionId { get; set; }

        public int? YoungestAgeServed { get; set; }

        public int? OldestAgeServed { get; set; }

        public bool? ServesChildrenWithSpecialNeeds { get; set; }

        [StringLength(60)]
        public string ELClassGroupCurriculumType { get; set; }

        public int? RefELGroupSizeStandardMetId { get; set; }

        public int? RefFrequencyOfServiceId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual ELClassSection ELClassSection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefELGroupSizeStandardMet RefELGroupSizeStandardMet { get; set; }

        public virtual RefFrequencyOfService RefFrequencyOfService { get; set; }
    }
}
