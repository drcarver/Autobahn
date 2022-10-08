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
    [Table("K12SchoolIndicatorStatus", Schema ="K12")]
    public partial class K12SchoolIndicatorStatus
    {
        [Key]
        public int K12SchoolIndicatorStatusId { get; set; }
        public int K12SchoolId { get; set; }
        public int RefIndicatorStatusTypeId { get; set; }
        public int? RefIndicatorStateDefinedStatusId { get; set; }
        public int? RefIndicatorStatusSubgroupTypeId { get; set; }
        [StringLength(100)]
        public string? IndicatorStatusSubgroup { get; set; }
        [StringLength(100)]
        public string? IndicatorStatus { get; set; }
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
        public int? RefIndicatorStatusCustomTypeId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12schoolIndicatorStatuses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("K12schoolId")]
        [InverseProperty("K12schoolIndicatorStatuses")]
        public virtual K12School K12school { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12schoolIndicatorStatuses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIndicatorStateDefinedStatusId")]
        [InverseProperty("K12schoolIndicatorStatuses")]
        public virtual RefIndicatorStateDefinedStatus? RefIndicatorStateDefinedStatus { get; set; }
        [ForeignKey("RefIndicatorStatusCustomTypeId")]
        [InverseProperty("K12schoolIndicatorStatuses")]
        public virtual RefIndicatorStatusCustomType? RefIndicatorStatusCustomType { get; set; }
        [ForeignKey("RefIndicatorStatusSubgroupTypeId")]
        [InverseProperty("K12schoolIndicatorStatuses")]
        public virtual RefIndicatorStatusSubgroupType? RefIndicatorStatusSubgroupType { get; set; }
        [ForeignKey("RefIndicatorStatusTypeId")]
        [InverseProperty("K12schoolIndicatorStatuses")]
        public virtual RefIndicatorStatusType RefIndicatorStatusType { get; set; } = null!;
    }
}
