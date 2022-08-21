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
    [Table("LearnerActivity_LearningResource")]
    [Index("LearnerActivityId", "LearningResourceId", Name = "IX_LearnerActivity_LearningResource", IsUnique = true)]
    public partial class LearnerActivityLearningResource
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("LearnerActivity_LearningResourceId")]
        public int LearnerActivityLearningResourceId { get; set; }
        /// <summary>
        /// Foreign key - LearnerActivity
        /// </summary>
        public int LearnerActivityId { get; set; }
        /// <summary>
        /// Foreign key - LearningResource
        /// </summary>
        public int LearningResourceId { get; set; }
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
        [InverseProperty("LearnerActivityLearningResources")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LearnerActivityId")]
        [InverseProperty("LearnerActivityLearningResources")]
        public virtual LearnerActivity LearnerActivity { get; set; } = null!;
        [ForeignKey("LearningResourceId")]
        [InverseProperty("LearnerActivityLearningResources")]
        public virtual LearningResource LearningResource { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("LearnerActivityLearningResources")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
