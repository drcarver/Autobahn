using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("LearningResourcePeerRating", Schema = "LearningResources")]
    public partial class LearningResourcePeerRating
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int LearningResourcePeerRatingId { get; set; }
        /// <summary>
        /// Foreign key - LearningResource
        /// </summary>
        public int LearningResourceId { get; set; }
        /// <summary>
        /// Foreign key - Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Foreign key - PeerRatingSystem
        /// </summary>
        public int PeerRatingSystemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "numeric(18, 4)")]
        public decimal? Value { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("LearningResourcePeerRatings")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LearningResourceId")]
        [InverseProperty("LearningResourcePeerRatings")]
        public virtual LearningResource LearningResource { get; set; } = null!;
        [ForeignKey("PeerRatingSystemId")]
        [InverseProperty("LearningResourcePeerRatings")]
        public virtual PeerRatingSystem PeerRatingSystem { get; set; } = null!;
        [ForeignKey("PersonId")]
        [InverseProperty("LearningResourcePeerRatings")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("LearningResourcePeerRatings")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
