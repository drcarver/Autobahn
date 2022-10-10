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
    [Table("CourseSectionLocation", Schema = "Education.Common")]
    public partial class CourseSectionLocation
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int CourseSectionLocationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int ClassroomId { get; set; }
        public int CourseSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInstructionLocationTypeId { get; set; }
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

        [ForeignKey("ClassroomId")]
        [InverseProperty("CourseSectionLocations")]
        public virtual Classroom Classroom { get; set; } = null!;
        [ForeignKey("CourseSectionId")]
        [InverseProperty("CourseSectionLocations")]
        public virtual CourseSection CourseSection { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CourseSectionLocations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CourseSectionLocations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefInstructionLocationTypeId")]
        [InverseProperty("CourseSectionLocations")]
        public virtual RefInstructionLocationType? RefInstructionLocationType { get; set; }
    }
}
