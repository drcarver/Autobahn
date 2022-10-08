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
    [Table("CourseSectionLevel", Schema = "Common")]
    [Index("CourseSectionId", "RefCourseLevelTypeId", Name = "IX_CourseSection_RefCourseLevelType", IsUnique = true)]
    public partial class CourseSectionLevel
    {
        [Key]
        public int CourseSectionLevelId { get; set; }
        public int CourseSectionId { get; set; }
        public int RefCourseLevelTypeId { get; set; }
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

        [ForeignKey("CourseSectionId")]
        [InverseProperty("CourseSectionLevels")]
        public virtual CourseSection CourseSection { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CourseSectionLevels")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CourseSectionLevels")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCourseLevelTypeId")]
        [InverseProperty("CourseSectionLevels")]
        public virtual RefCourseLevelType RefCourseLevelType { get; set; } = null!;
    }
}
