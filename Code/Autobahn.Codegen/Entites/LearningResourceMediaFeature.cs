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
    [Table("LearningResourceMediaFeature", Schema = "LearningResources")]
    public partial class LearningResourceMediaFeature
    {
        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int LearningResourceMediaFeatureId { get; set; }
        /// <summary>
        /// Foreign key to LearningResource
        /// </summary>
        public int LearningResourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefLearningResourceMediaFeatureTypeId { get; set; }
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
        [InverseProperty("LearningResourceMediaFeatures")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LearningResourceId")]
        [InverseProperty("LearningResourceMediaFeatures")]
        public virtual LearningResource LearningResource { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("LearningResourceMediaFeatures")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefLearningResourceMediaFeatureTypeId")]
        [InverseProperty("LearningResourceMediaFeatures")]
        public virtual RefLearningResourceMediaFeatureType RefLearningResourceMediaFeatureType { get; set; } = null!;
    }
}
