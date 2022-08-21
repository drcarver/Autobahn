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
    [Table("K12SchoolGradeLevelsApproved")]
    public partial class K12schoolGradeLevelsApproved
    {
        [Key]
        [Column("K12SchoolGradeLevelsApprovedId")]
        public int K12schoolGradeLevelsApprovedId { get; set; }
        [Column("K12SchoolId")]
        public int K12schoolId { get; set; }
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
        [InverseProperty("K12schoolGradeLevelsApproveds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12schoolId")]
        [InverseProperty("K12schoolGradeLevelsApproveds")]
        public virtual K12school K12school { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12schoolGradeLevelsApproveds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefGradeLevelId")]
        [InverseProperty("K12schoolGradeLevelsApproveds")]
        public virtual RefGradeLevel RefGradeLevel { get; set; } = null!;
    }
}
