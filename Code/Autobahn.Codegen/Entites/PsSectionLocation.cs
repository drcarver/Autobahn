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
    [Table("PsSectionLocation", Schema = "Postsecondary")]
    public partial class PsSectionLocation
    {
        [Key]
        public int PsSectionLocationId { get; set; }
        public int PsSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? CourseInstructionSiteName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCourseInstructionSiteTypeId { get; set; }
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
        [InverseProperty("PsSectionLocations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PsSectionId")]
        [InverseProperty("PsSectionLocations")]
        public virtual PsSection PsSection { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsSectionLocations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCourseInstructionSiteTypeId")]
        [InverseProperty("PsSectionLocations")]
        public virtual RefCourseInstructionSiteType? RefCourseInstructionSiteType { get; set; }
    }
}
