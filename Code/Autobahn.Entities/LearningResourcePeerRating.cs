using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("LearningResourcePeerRating")]
    public partial class LearningResourcePeerRating
    {
        public int LearningResourcePeerRatingId { get; set; }

        public int LearningResourceId { get; set; }

        public int PersonId { get; set; }

        public int PeerRatingSystemId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Value { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual PeerRatingSystem PeerRatingSystem { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
