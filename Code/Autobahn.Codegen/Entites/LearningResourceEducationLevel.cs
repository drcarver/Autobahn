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
    [Table("LearningResourceEducationLevel", Schema = "LearningResources")]
    [Index("LearningResourceId", "RefEducationLevelId", Name = "IX_LearningResourceEducationLevel", IsUnique = true)]
    public partial class LearningResourceEducationLevel
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int LearningResourceEducationLevelId { get; set; }
        /// <summary>
        /// Foreign key - LearningResource
        /// </summary>
        public int LearningResourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefEducationLevelId { get; set; }
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
        [InverseProperty("LearningResourceEducationLevels")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LearningResourceId")]
        [InverseProperty("LearningResourceEducationLevels")]
        public virtual LearningResource LearningResource { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("LearningResourceEducationLevels")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEducationLevelId")]
        [InverseProperty("LearningResourceEducationLevels")]
        public virtual RefEducationLevel RefEducationLevel { get; set; } = null!;
    }
}
