using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELQualityRatingImprovement")]
    public partial class ELQualityRatingImprovement
    {
        public int ELQualityRatingImprovementId { get; set; }

        public Guid OrganizationId { get; set; }

        public int? NumberQrisLevels { get; set; }

        [Column(TypeName = "date")]
        public DateTime? QrisAwardDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? QRISExpirationDate { get; set; }

        public int? RefQrisParticipationId { get; set; }

        [StringLength(45)]
        public string QrisScore { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefQrisParticipation RefQrisParticipation { get; set; }
    }
}
