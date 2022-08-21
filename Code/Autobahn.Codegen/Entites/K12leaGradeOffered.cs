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
    [Table("K12LeaGradeOffered")]
    public partial class K12leaGradeOffered
    {
        [Key]
        [Column("K12LeaGradeOfferedId")]
        public int K12leaGradeOfferedId { get; set; }
        [Column("K12LeaId")]
        public int K12leaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefGradeLevelId { get; set; }
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
        [InverseProperty("K12leaGradeOffereds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12leaId")]
        [InverseProperty("K12leaGradeOffereds")]
        public virtual K12lea K12lea { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leaGradeOffereds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGradeLevelId")]
        [InverseProperty("K12leaGradeOffereds")]
        public virtual RefGradeLevel RefGradeLevel { get; set; } = null!;
    }
}
