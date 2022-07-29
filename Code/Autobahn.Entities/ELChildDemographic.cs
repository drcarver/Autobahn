using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELChildDemographic")]
    public partial class ELChildDemographic
    {
        public int ELChildDemographicId { get; set; }

        public int PersonId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FosterCareStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FosterCareEndDate { get; set; }

        public bool? OtherRaceIndicator { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
