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
    [Table("Classroom")]
    public partial class Classroom
    {
        public Classroom()
        {
            CourseSectionLocations = new HashSet<CourseSectionLocation>();
        }

        [Key]
        public int ClassroomId { get; set; }
        /// <summary>
        /// Foreign key - Location
        /// </summary>
        public int LocationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? ClassroomIdentifier { get; set; }
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
        [InverseProperty("Classrooms")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LocationId")]
        [InverseProperty("Classrooms")]
        public virtual Location Location { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Classrooms")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("Classroom")]
        public virtual ICollection<CourseSectionLocation> CourseSectionLocations { get; set; }
    }
}
