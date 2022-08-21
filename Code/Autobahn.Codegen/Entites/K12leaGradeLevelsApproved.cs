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
    [Table("K12LeaGradeLevelsApproved")]
    public partial class K12leaGradeLevelsApproved
    {
        [Key]
        [Column("K12LeaGradeLevelsApprovedId")]
        public int K12leaGradeLevelsApprovedId { get; set; }
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
        [InverseProperty("K12leaGradeLevelsApproveds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12leaId")]
        [InverseProperty("K12leaGradeLevelsApproveds")]
        public virtual K12lea K12lea { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12leaGradeLevelsApproveds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGradeLevelId")]
        [InverseProperty("K12leaGradeLevelsApproveds")]
        public virtual RefGradeLevel RefGradeLevel { get; set; } = null!;
    }
}
