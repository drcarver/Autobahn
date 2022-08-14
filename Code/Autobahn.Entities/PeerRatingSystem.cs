using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PeerRatingSystem")]
    public partial class PeerRatingSystem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PeerRatingSystem()
        {
            LearningResourcePeerRatings = new HashSet<LearningResourcePeerRating>();
        }

        public int PeerRatingSystemId { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaximumValue { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MinimumValue { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OptimumValue { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningResourcePeerRating> LearningResourcePeerRatings { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
